using ConsoleUI.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Concrete.InMemory
{
    internal class InMemoryCarDal : ICarDal
    {

        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>()
            {
                // From Any DB service
                new Car { Id=1,BrandId=14324, Description = "Ford", ModelYear=2008, ColorId=15},
                new Car { Id=2,BrandId=13213, Description = "Audi", ModelYear=1996, ColorId=3},
                new Car { Id=3,BrandId=23124, Description = "Opel", ModelYear=1999, ColorId=2},
                new Car { Id=4,BrandId=24354, Description = "Ferrari", ModelYear=2022, ColorId=65},
                new Car { Id=5,BrandId=21232, Description = "Lamborghini", ModelYear=2020, ColorId=1},

            };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = cars.SingleOrDefault(p => p.Id == car.Id);

            cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return cars;
        }

        public List<Car> GetAllByCategory(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int Id)
        {
            return cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
