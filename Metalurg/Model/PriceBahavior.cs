using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalurg.Model
{
    internal static class PriceBahavior
    {

        public static void Add(DateTime date, Product product, TypePrice typePrice,int Value)
        {
            ContextData.Context.Prices.Add(new Price() { Date = date, Product = product, PriceType = typePrice, Value = Value });
            ContextData.Context.SaveChanges();
        }

        public static void Remove(DateTime date, Product product, TypePrice typePrice) 
        {
            var t = ContextData.Context.Prices.FirstOrDefault(u => u.Product == product && u.Date ==date && typePrice == u.PriceType);
            if (t != null)
            {
                ContextData.Context.Prices.Remove(t);
            }
            ContextData.Context.SaveChanges();
        }

        public static Price? GetPrice(DateTime date, Product product, TypePrice typePrice)
        {
            return ContextData.Context.Prices.Where(u => u.Product == product && typePrice == u.PriceType && u.Date <= date)
                .MaxBy(u => u.Date);
                
        }

        public static Price[] GetPrice(Product product)
        {
            return ContextData.Context.Prices.Where(u => u.Product == product ).OrderBy(u=>u.Date).ToArray();

        }

        public static Price[] GetPrice(DateTime date)
        {
            return ContextData.Context.Prices.Where(u => u.Date <= date)
                .GroupBy(u => new { u.Product, u.PriceType })
                .Select(n => new Price()
                {
                    Product = n.Key.Product,
                    PriceType = n.Key.PriceType,
                    Date = n.Max(x => x.Date)
                }
                ).Join(ContextData.Context.Prices,
                u=>new {u.Product,u.PriceType,u.Date},
                p=> new { p.Product, p.PriceType, p.Date },
                (u,p)=>new Price()
                { Date = u.Date,
                Product=u.Product,
                PriceType=u.PriceType,
                Value=p.Value}).ToArray();
        }
        public static Price[] GetPrice(DateTime date, Product product)
        {
            return ContextData.Context.Prices.Where(u => u.Date <= date && u.Product==product)
               .GroupBy(u => new { u.Product, u.PriceType })
               .Select(n => new Price()
               {
                   Product = n.Key.Product,
                   PriceType = n.Key.PriceType,
                   Date = n.Max(x => x.Date)
               }
               ).Join(ContextData.Context.Prices,
               u => new { u.Product, u.PriceType, u.Date },
               p => new { p.Product, p.PriceType, p.Date },
               (u, p) => new Price()
               {
                   Date = u.Date,
                   Product = u.Product,
                   PriceType = u.PriceType,
                   Value = p.Value
               }).ToArray();
        }
        public static Price[] GetPrice(DateTime date, TypePrice typePrice)
        {

            return ContextData.Context.Prices.Where(u => u.Date <= date && u.PriceType==typePrice)
               .GroupBy(u => new { u.Product, u.PriceType })
               .Select(n => new Price()
               {
                   Product = n.Key.Product,
                   PriceType = n.Key.PriceType,
                   Date = n.Max(x => x.Date)
               }
               ).Join(ContextData.Context.Prices,
               u => new { u.Product, u.PriceType, u.Date },
               p => new { p.Product, p.PriceType, p.Date },
               (u, p) => new Price()
               {
                   Date = u.Date,
                   Product = u.Product,
                   PriceType = u.PriceType,
                   Value = p.Value
               }).ToArray();               


        }

    }
}
