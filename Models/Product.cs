using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SakariaBookstore.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Categories { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public bool isAvailable { get; set; }
    }
}
