using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class OnionArchitecture101DbContext : DbContext
    {
        public OnionArchitecture101DbContext(DbContextOptions options) : base(options) // IoC Container için
        {

        }

        //tabloları ef ile entegre etmek
        public DbSet<Product> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Product> Customers { get; set; }
    }
}
