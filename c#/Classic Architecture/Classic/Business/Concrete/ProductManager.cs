using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILogger = Business.CCS.ILogger;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;

        public ProductManager(IProductDal productDal,ICategoryService categoryService)
        {
            _productDal = productDal;
            //_categoryDal = categoryDal; // Bir Entity manager kendi Dal'ı haricinde başka bir
            // field'ı injeckte edemez.

            // Onun yerine direkt olarak servis injekte edilmelidir.

            _categoryService = categoryService;
        }
        //inmemory cache
        
        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        [CacheAspect] // key,value
        public IDataResult<List<Product>> GetAll()
        {
            //Codes


            // has permission??

            //if(DateTime.Now.Hour==22) // => business code to create a maintenance time on system
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return  new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
                
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>
                (_productDal.GetAll(p => p.UnitPrice>=min && p.UnitPrice<=max));
        }
        //If cache hasn't been managed properly, it may not match with the database

        //Claim => yetki  
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Product product)
        {



            //validation
            //bad code--- REFACTORED ---
            // ValidationTool.Validate(new ProductValidator(),product); //Validation tool is used, so we can change tech beyond it

            //CROSS CUTTING CONCERNS (CCC) => intersection point of layers in this arch
            //log
            //cache
            //performance
            //transaction
            //permission

            //Interception => the art of not putting try catch everywhere :)

            //no-if business codes here we use fluentvalidation to manage business codes

            ///////////////////////////////business codes/////////////////////


            IResult result = BusinessRules.Run(CheckIfProductNameUsed(product.ProductName),
                CheckIfProductCountOfCategoryCorrect(product.CategoryId),
                CheckIfCategoryLimitExceded());
           
            if(result != null)
            {
                return result;
            }
            return new ErrorResult();

            ///////////
            ///NOT using nested if to write logic, instead we use a engine to improve readability
            ///
            ///DON'T WRITE LIKE THIS !!
            //if(CheckIfProductCountOfCategoryCorrect(product.CategoryId).Success)
            //{
            //    if(CheckIfProductNameUsed(product.ProductName).Success)
            //    {
            //        _productDal.Add(product);

            //        return new SuccessResult(Messages.ProductAdded);
            //    }

            //}





        }

        [CacheAspect]
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Product product)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result >= 15)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfProductNameUsed(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Product product)
        {
            throw new NotImplementedException();
        }
    }


}
