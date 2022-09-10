using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Abstract;

namespace Vehicles.Concrete
{
    internal class Bus : IVehicle
    {
        public int HgsNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OwnerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OwnerSurname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PassDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PassCost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
