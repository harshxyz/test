using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FirstWebApi.Models;

namespace FirstWebApi.Models
{
    public class EmployeeDB:DbContext
    {
        public EmployeeDB() : base("mycon")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}