using System.Collections.Generic;
using System.Linq;
using Cake.Dto.Cake;

namespace Cake.Services.Cake
{
    public interface ICakeService
    {
        IQueryable<CakeDto> GetCakes(CakeQuery cakeQuery);
        IList<CakeTypeDto> GetScenarios();
    }
}