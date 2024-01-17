using catsapi.Models;
namespace catsapi.Data.EFCore
{
    public class EFCoreCatRepository : EfCoreRepository<Cat, CatContext>
    {
        public EFCoreCatRepository(CatContext context) : base(context)
        {

        }
    }
}