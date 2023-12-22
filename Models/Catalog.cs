using Shop.Components.Pages;

namespace Shop.Models
{
    public class Catalog
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public Catalog()
        {
            Products = new List<Product>
            {
                    new Product
                    {
                        Id = 1,
                        Name = "Товар 1",
                        Price =  10.99m,
                        Description = "шарики светлые в ассортименте",
                        ImageUrl = Path.Combine("images", "image1.jpeg")
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Товар 2",
                        Price = 15.99m,
                        Description = "шарики темные в ассортименте ",
                         ImageUrl = Path.Combine("images", "image2.jpg")
                    },

            };
        }


    }
}
