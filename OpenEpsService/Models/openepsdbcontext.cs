using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OpenEpsService.Models
{
    public class HRMContext : DbContext
    {
        public HRMContext(): base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}