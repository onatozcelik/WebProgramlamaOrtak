using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBookstore.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product(){ID=1,Name="Don Quixote",Author="Miguel de Cervantes",Price=17,Categories="Paperback",isAvailable=true},
                new Product(){ID=2,Name="Harry Potter",Author="J.K Rowling",Price=20,Categories="Paperback",isAvailable=true},
                new Product(){ID=3,Name="The Hunger Games",Author="Suzanne Collins",Price=20,Categories="Paperback",isAvailable=false}
            };
        }
        public static List<Product> Product
        {
            get { return _products; }
        }

        public static void AddProduct(Product entity)
        {

            _products.Add(entity);
        }


    }
}
