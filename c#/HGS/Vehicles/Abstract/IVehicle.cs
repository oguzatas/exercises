using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Abstract
{
    public interface IVehicle
    {
        public int HgsNumber { get; set; }

        public string OwnerName { get; set; }

        public string OwnerSurname { get; set; }

        public int PassDate { get; set; }

        public int Balance { get; set; }

        public int PassCost { get; set; }
    }
}
