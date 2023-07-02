using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product:IUpdateEnty<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Price>  Prices { get; set;}
        public TypeProduct TypeProduct { get; set; }

        public Product Update(Product entity)
        {
            if (entity == null) throw new ArgumentNullException();
            Name = entity.Name;
            Description = entity.Description;
            return this;
        }
        public override string ToString()
        {
            return $"{Name}  {Description}";
        }
    }

    public enum TypeProduct
    {
        Goods,
        Factory,
        Product
    }
}
