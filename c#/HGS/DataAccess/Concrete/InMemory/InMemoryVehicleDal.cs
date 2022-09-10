using DataAccess.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Abstract;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryVehicleDal : IVehicleDal
    {

        public InMemoryVehicleDal()
        {

            List<IVehicle> vehicles;

            vehicles = new List<IVehicle>()
            {
                
                
            };
        }






      


        public void Add(IVehicle entity)
        {
            
        }

        public void Delete(IVehicle entity)
        {
            throw new NotImplementedException();
        }

        public IVehicle Get(Expression<Func<IVehicle, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<IVehicle> GetAll(Expression<Func<IVehicle, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<IVehicle> GetAllById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(IVehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
