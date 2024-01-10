using Microsoft.AspNetCore.Mvc;
using ProductsMicroService.Models;
using ProductsMicroService.Services;

namespace ProductsMicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : BaseController<Product>
    {
        public ProductsController(ILogger<BaseController<Product>> logger, IRepository<Product> _repo) : base(logger, _repo)
        {
        }
    }
}
