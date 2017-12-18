using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
   
    public class Car
    {
        public int CarId { get; set; }
        public string Foto { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}