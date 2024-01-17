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
            IEnumerable<Cat> cats = await _catService.GetCats();
            if(cats != null) 
                return Ok(cats);
            else 
                return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cat>> GetCat(long id)
        { 
            Cat c =  await _catService.GetCat(id);
            if(c != null){
                return Ok(c);
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Cat>> PostCat(Cat cat)
        {
            Cat c = await _catService.PostCat(cat);
            return CreatedAtAction("Cat", new { id = cat.Id }, cat);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCat(long id)
        {
            await _catService.Delete(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, Cat cat)
        {
            if(id != cat.Id) return BadRequest();
            await _catService.PutCat(cat);
            return NoContent();
        }
    }
}