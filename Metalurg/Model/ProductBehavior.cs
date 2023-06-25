using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalurg.Model
{
    internal static class ProductBehavior
    {
        public static void Add(Product product)
        {
            if (!Validate(product)) throw new Exception("Product Not vilidate");

            ContextData.Context.Products.Add(product);
            ContextData.Context.SaveChanges();
        }

        public static bool Validate(Product product)
        {
            return true;
        }



        public static void Update(Product product)
        {
            if (!Validate(product)) throw new Exception("Product Not vilidate");

            var t = ContextData.Context.Products.FirstOrDefault(u => u.Id == product.Id);
            if (t != null)
            {
                t.Update(product);
                ContextData.Context.Products.Update(t);
            }
            ContextData.Context.SaveChanges();
        }

        public static void Remove(int id) 
        {
            var t = ContextData.Context.Products.FirstOrDefault(u => u.Id == id);
            if (t != null)
            {
                ContextData.Context.Products.Remove(t);
            }
            ContextData.Context.SaveChanges();

        }

        public static Product? GetProduct(int id)
        {
            return ContextData.Context.Products.FirstOrDefault(u => u.Id == id); 
        }

        public static Product[] GetProduct()
        {
            ContextData.Context.Products.Load();
            return ContextData.Context.Products.ToArray();
        }

    }
}
