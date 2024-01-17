
using catsapi.Models;

namespace catsapi.Services
{
    public interface IService 
    {
        public Task<IEnumerable<Cat>> GetCats();
        public Task<Cat> GetCat(long id);
        public Task<Cat> PostCat(Cat cat);
        public Task<Cat> Delete(long id);

        public Task<Cat> PutCat(Cat cat);
    }
}

