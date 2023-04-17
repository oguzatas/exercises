using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence
{
    public static class ServiceRegistration
    { //IOC containera extension sağlayan yapı.
        public static void AddPersistenceServices(this IServiceCollection services)
        { //Kodun içerisine connection string ve konfigürasyon değerleri yazılmaz. Best practice değildir.
            services.AddDbContext<OnionArchitecture101DbContext>(options => options.UseNpgsql("User ID=postgres;" +
                "Password=123456;Host=localhost;Port=5432;Database=OnionArchitecture101Db;Pooling=true" +
                ";Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;")); // connection string
        }
    }
}
