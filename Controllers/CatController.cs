using catsapi.Models;
using catsapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace catsapi.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase {
        
        private readonly IService _catService;
        
        public CatController(IService catService)
        {
            _catService = catService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cat>>> GetGatos()
        {
            return await _catService.GetCats();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cat>> GetCat(long id)
        { 
          return await _catService.GetCat(id);
        }

        [HttpPost]
        public async Task<ActionResult<Cat>> PostCat(Cat cat)
        {
          return await _catService.PostCat(cat);
        }

    }
}