using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Recept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Product Product { get; set; }
        public int Value { get; set; }
    }

    public class Recept_Product
    {
        public Recept Recept { get; set; }
        public Product Product { get; set; }
        public int Value { get; set; } 
    }
    


}
