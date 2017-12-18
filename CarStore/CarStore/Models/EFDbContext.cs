using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class EFDbContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}