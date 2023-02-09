using Business.Abstract;
using ConsoleUI.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public Car Add(Car car)
        {
            return new Car();
        }

        public List<Car> GetAll()
        {
            return new List<Car>(_carDal.GetAll());
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return new List<Car>(_carDal.GetAll(p => p.BrandId == brandId));    
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return new List<Car>(_carDal.GetAll(p=> p.DailyPrice == min && p.DailyPrice < max));
        }
    }
}
