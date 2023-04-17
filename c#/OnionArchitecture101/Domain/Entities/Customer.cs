using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {
        public ICollection<Product> Orders { get; set; }

        public Customer _Customer { get; set; }

        public string Name { get; set; }
    }
}
