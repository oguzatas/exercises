using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]         /*Attribute=> signing technique (Annotation in java) */
    public class ProductsController : ControllerBase
    {
        /*Loosely coupled => weak dependence, instead of creating an dependency chain 
         we generate a constructor */
        //naming convention => use _ when defining private fields
        IProductService _productService;

        //IoC Container -- Inversion of Control

        public ProductsController(IProductService productService)
        {
            _productService = productService; /* In java and C# you can't use
                                                 this without field. In Jscript
                                                 you can.*/
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain , bad code -- to fix this, make constructor injection
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycategory")]

        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getproductdetails")]

        public IActionResult GetProductDetails(int categoryId)
        {
            var result = _productService.GetProductDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]

        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}
