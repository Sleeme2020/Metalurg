using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalurg.Model
{
    public static class ProductionBehavior
    {
        public static void Add(Production production , List<Product_Production> product_Production)
        {
            if (product_Production is null || product_Production.Count == 0) throw new Exception();
            product_Production.ForEach(p=>p.Production=production);
            ContextData.Context.Add(production);
            ContextData.Context.AddRange(product_Production);
            ContextData.Context.SaveChanges();
        }
        public static void Update(Production production, List<Product_Production> product_Production)
        {
            if (product_Production is null || product_Production.Count == 0) throw new Exception();
            var t = ContextData.Context.Productions.FirstOrDefault(u => u.Id == production.Id);
            if (t != null)
            {
                t.Update(production);
                ContextData.Context.Update(t);
            }
            ContextData.Context.SaveChanges();
            var list = ContextData.Context.Product_Productions.Where(p=>p.Production==production);
            ContextData.Context.RemoveRange(list);
            ContextData.Context.AddRange(product_Production);
            ContextData.Context.SaveChanges();
        }

        public static Production? GetProduction(int id)
        {
            return ContextData.Context.Productions.FirstOrDefault(p=>p.Id==id);
        }

        public static Production[] GetProduction()
        {
            ContextData.Context.Productions.Load();
            return ContextData.Context.Productions.ToArray();
        }

        public static Product_Production[] GetProduction(Production production)
        {
           
            return ContextData.Context.Product_Productions.Where(u=>u.Production==production).ToArray();
        }
        public static Product_Production[] GetProduction(Product product)
        {            
            return ContextData.Context.Product_Productions.Where(u => u.Product==product).ToArray();
        }

    }
}
