namespace Spisok
{
    public static class ClassCollect
    {
        public static List<Product> Products = new List<Product>();
        public static List<Spisok> Spisok = new List<Spisok>();
        public static void Add(Product product)
        {
            var prod =Products.FirstOrDefault(u => u == product);
            if (prod != null) throw new Exception();
            Products.Add(product);
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Spisok
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Prod_spis> Prod_s { get;set; }
    }

    public class Prod_spis
    {
        public Product Product { get; set; }
        public int value { get; set; }
    }

}