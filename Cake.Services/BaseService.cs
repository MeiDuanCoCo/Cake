using Cake.Domain;

namespace Cake.Services
{
    public class BaseService
    {
        public readonly CakeContext _dbContext;

        public BaseService(CakeContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
