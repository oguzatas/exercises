using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Abstract;

namespace Business.Concrete
{
    public class BoxOffice : IBoxOfficeService
    {
       public static void OnPass(IVehicle vehicle)
        {
           if(vehicle.Balance<vehicle.PassCost)
            {
                // TODO 
            }
           else
            {
                vehicle.Balance =- vehicle.PassCost;
            }
            
           
                
        } 
    }
}
