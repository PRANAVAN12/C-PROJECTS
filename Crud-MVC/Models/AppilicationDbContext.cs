using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Crud_MVC.Models
{
    public class AppilicationDbContext : DbContext
    {
        public AppilicationDbContext(DbContextOptions<AppilicationDbContext> options) : base(options)
        {

        }
        public DbSet<NewEmpClass> EmployeTable { get; set;  }
    }
}
