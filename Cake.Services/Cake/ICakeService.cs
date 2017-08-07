using System.Linq;
using Cake.Domain.Cake;

namespace Cake.Services.Cake
{
    public interface ICakeService
    {
        IQueryable<Domain.Cake.Cake> GetCakes(CakeQuery cakeQuery);
    }
}