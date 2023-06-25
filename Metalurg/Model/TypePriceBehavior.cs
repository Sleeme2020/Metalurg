using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalurg.Model
{
    internal static class TypePriceBehavior
    {
        public static void Add(string name)
        {
            ContextData.Context.TypePrices.Add(new TypePrice() { Name = name });
            ContextData.Context.SaveChanges();
        }

        public static void Remove(int id) 
        {
             var t= ContextData.Context.TypePrices.FirstOrDefault(u => u.Id == id);
            if(t!= null)
            {
                ContextData.Context.TypePrices.Remove(t);
            }
            ContextData.Context.SaveChanges();
        }

        public static void update(TypePrice typePrice)
        {
            var t = ContextData.Context.TypePrices.FirstOrDefault(u => u.Id == typePrice.Id);
            if (t != null)
            {
                t.Name = typePrice.Name;
                ContextData.Context.TypePrices.Update(t);
            }
            ContextData.Context.SaveChanges();
        }

        public static TypePrice? GetType(int  id) 
        {
            return ContextData.Context.TypePrices.FirstOrDefault(u => u.Id == id);
        }

        public static TypePrice[] GetType()
        {
            ContextData.Context.TypePrices.Load();
            return ContextData.Context.TypePrices.ToArray();
        }
    }
}
