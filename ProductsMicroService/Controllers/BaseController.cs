using Microsoft.AspNetCore.Mvc;
using ProductsMicroService.Services;

namespace ProductsMicroService.Controllers
{
    public abstract class BaseController<T> : Controller where T : class
    {
        private readonly IRepository<T> _repo;
        private readonly ILogger<BaseController<T>> _logger;

        public BaseController(ILogger<BaseController<T>> logger, IRepository<T> _repo)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpGet]
        public IReadOnlyCollection<T> GetAll()
        {
            return _repo.GetProducts();
        }
    }
}
