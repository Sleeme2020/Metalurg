using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Production:IUpdateEnty<Production>
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; }
        public List<Product_Production> Product { get; set; }
        public Recept Recept { get; set; }
        public int value { get; set; }

        public Production Update(Production entity)
        {
            DateTime = entity.DateTime;
            User = entity.User;
            Product = entity.Product;
            Recept = entity.Recept;
            value = entity.value;
            return this;
        }
    }

    public class Product_Production
    {
        public Production Production { get; set; }
        public int ProductionId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Value { get; set; }
    }
}
