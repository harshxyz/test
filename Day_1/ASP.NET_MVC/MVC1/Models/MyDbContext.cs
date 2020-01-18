using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC1.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(): base("name=conn")
        {

        }
        public DbSet<MyUser> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}