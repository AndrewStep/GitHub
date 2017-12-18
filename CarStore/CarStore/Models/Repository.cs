using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Car> Cars
        {
            get { return context.Cars; }
        }
    }
}