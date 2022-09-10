﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal interface IEntityCar
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }

        public string Description { get; set; }
    }
}
