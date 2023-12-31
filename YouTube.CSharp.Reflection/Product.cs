namespace YouTube.CSharp.Reflection
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

   
    public static class ProductSeed
    {
        public static List<Product> products = new()
        {
            new(){Id=1,Title="Brick",Price=2.25m},
            new(){Id=2,Title="Marble",Price=8.35m},
            new(){Id=3,Title="Cement",Price=4.35m},
            new(){Id=4,Title="Plaster",Price=1.15m},
            new(){Id=5,Title="Nails",Price=3.20m}
        };


    }
}
