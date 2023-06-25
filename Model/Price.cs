using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Price
    {
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public TypePrice PriceType { get; set; }
        public int PriceTypeId { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            if (PriceType == null)
                return Value.ToString();
            else return $"{Date} - {PriceType.Name} - {Value}";
        }

    }
}
