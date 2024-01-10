using ProductsMicroService.Models;

namespace ProductsMicroService.Services
{
    public class ProductRepository : IRepository<Product>
    {
        private IReadOnlyCollection<Product> _products;
        public ProductRepository()
        {
            _products = InitializeProductsArray();
        }

        public Product GetById(int id)
        {
            return _products.First(x => x.Id == id);
        }

        public IReadOnlyCollection<Product> GetProducts()
        {
            return this._products;
        }

        private IReadOnlyCollection<Product> InitializeProductsArray()
        {
            return new Product[]
            {
                new Product()
                {
                    Id = 1,
                    Name = "CPU",
                    Price=490.99m,
                    Image="https://media.memoryexpress.com/Images/Products/MX68271/0?Size=Default"
                },
                new Product()
                {
                     Id = 2,
                    Name = "GPU",
                    Price=1190.99m,
                    Image="https://www.hellotech.com/blog/wp-content/uploads/2020/02/what-is-a-gpu-770x462.jpg"
                },
                new Product()
                {
                     Id = 3,
                    Name = "RAM",
                    Price=190.99m,
                    Image="https://i.ebayimg.com/images/g/qm8AAOSwX1Vggpg1/s-l1200.webp"
                },
                new Product()
                {
                     Id = 4,
                    Name = "Monitor",
                    Price=290.99m,
                    Image="https://images.philips.com/is/image/PhilipsConsumer/24M1N3200ZA_00-IMS-en_GB?wid=420&hei=360&$jpglarge$"
                },
            };
        }
    }
}
