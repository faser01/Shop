using Shop.Models;

namespace Shop.Services
{
    public class ProductService
        {
            private List<Product> _products;

            public ProductService()
            {
                _products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.99m, Description = "Description 1", ImageUrl = "https://example.com/image1.jpg" },
                new Product { Id = 2, Name = "Product 2", Price = 20.99m, Description = "Description 2", ImageUrl = "https://example.com/image2.jpg" }
            };
            }

            public List<Product> GetAll()
            {
                return _products;
            }

            public Product GetById(int id)
            {
                return _products.FirstOrDefault(p => p.Id == id);
            }

            public void Add(Product product)
            {
                product.Id = _products.Count + 1;
                _products.Add(product);
            }

            public void Update(int id, Product product)
            {
                var existingProduct = _products.FirstOrDefault(p => p.Id == id);
                if (existingProduct != null)
                {
                    existingProduct.Name = product.Name;
                    existingProduct.Price = product.Price;
                    existingProduct.Description = product.Description;
                    existingProduct.ImageUrl = product.ImageUrl;
                }
            }

            public void Delete(int id)
            {
                var product = _products.FirstOrDefault(p => p.Id == id);
                _products.Remove(product);
            }
        }
    
}
