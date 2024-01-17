
using Microsoft.AspNetCore.Mvc;
using catsapi.Models;
using catsapi.Data;

namespace catsapi.Services
{
    public class CatService : IService
    {
        private readonly IRepository<Cat> _repository;

        public CatService(IRepository<Cat> repo) {
            _repository = repo;
        }
        
        public async Task<ActionResult<IEnumerable<Cat>>> GetCats()
        {          
            return await _repository.GetAll();
        }

    }
}