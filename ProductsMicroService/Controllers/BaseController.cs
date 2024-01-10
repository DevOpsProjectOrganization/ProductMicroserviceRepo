using Microsoft.AspNetCore.Mvc;
using ProductsMicroService.Services;

namespace ProductsMicroService.Controllers
{
    public abstract class BaseController<T> : Controller where T : class
    {
        private readonly IRepository<T> _repo;
        private readonly ILogger<BaseController<T>> _logger;

        public BaseController(ILogger<BaseController<T>> logger, IRepository<T> repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            _logger.LogInformation("Retreived element with id: " + id);
            return _repo.GetById(id);
        }

        [HttpGet]
        public IReadOnlyCollection<T> GetAll()
        {
            _logger.LogInformation("Retreived elements");
            return _repo.GetProducts();
        }
    }
}
