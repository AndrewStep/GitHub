using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class CarsStoreDBContext : DbContext
    {
       
            public CarsStoreDBContext() : base("CarsStoreDBContext")
            { }
            public DbSet<User> Users { get; set; }
            public DbSet<Role> Roles { get; set; }

        public static CarsStoreDBContext Create()
        {
            return new CarsStoreDBContext();
        }
    }
}