using catsapi.Models;
using catsapi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    }
}