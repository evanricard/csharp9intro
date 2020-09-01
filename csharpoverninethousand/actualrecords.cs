using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpoverninethousand
{
    public class actualrecords
    {
        /*public? init-only auto-properties*/
        public record Product
        {
            public string Name;
            public int CategoryId;
        }
        /*!? Important, remember that the record is implicitly PUBLIC?...*/
        record newProduct
        {
            string Name { get; init; }
            int CategoryId { get; init; }
        }


        public void ESRB()
        {
            /*If we change to Products...*/
            var product = new Product
            {
                Name = "VideoGame",
                CategoryId = 1
            };

            var newProduct = product with { CategoryId = 2 };


            Assert.IsTrue(product.Equals(newProduct)); // returns false
            //product == newProduct; // returns false

            var newAnotherProduct = new Product
            {
                Name = "VideoGame",
                CategoryId = 1
            };

            product.Equals(newAnotherProduct); // returns true
            //product == newAnotherProduct; // returns false

        }
    }


    namespace CSharp9Demo.Models
    {
        //Positional Record
        public record Product(string Name, int CategoryId);

        public class ProductAmigo
        {
            public void Alacarte()
            {
                var product = new Product("VideoGame", 0);
                var (name, categoryId) = product;
            }

            public int CategoryId { get; init; }

`            Product product = new Book
            {
                Name = "VideoGame",
                CategoryId = 1,
                ISBN = "00000000000000"
            };

            var newProduct = product with { CategoryId = 2 }

            // newProduct.GetType().Name == Book
            // newProduct.Name == "VideoGame"
            // newProduct.CategoryId == 1
            // newProduct.ISBN == "00000000000000"

        var book = (Book)newProduct;
            book.ISBN; //available after casting
        }
    }


    //        class Subtype{
    //            public Subtype()
    //            {

    //            }
    //        }
    //        public record Subtype : Product
    //        {
    //            public string _ { get; init; }
    //    }
    //}


}

    /*We can of course go through this ceremony */
    //? public string Name { get; init; }
    //? public int CategoryId { get; init; }

    //? public Product(string name, int categoryId)
    //?  => (Name, CategoryId) = (name, categoryId);

    //? public void Deconstruct(out string name, out int categoryId)
    //?  => (name, categoryId) = (Name, CategoryId);
}
