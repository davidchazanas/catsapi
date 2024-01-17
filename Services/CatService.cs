using Microsoft.AspNetCore.Mvc;
using catsapi.Models;
using catsapi.Data;
using Microsoft.AspNetCore.Http.HttpResults;

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