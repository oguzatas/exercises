using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    //generic repository design pattern implementation
    public interface IRepository<T>  where T : BaseEntity   // Query ve commentleri ayırarak single responsibility ilkesine uyulur
    {
        DbSet<T> Table { get;  }
    }
}
