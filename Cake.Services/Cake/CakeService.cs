using System.Collections.Generic;
using System.Linq;
using Cake.Domain;
using Cake.Domain.Cake;
using Cake.Dto.Cake;

namespace Cake.Services.Cake
{
    public class CakeService : BaseService, ICakeService
    {
        public CakeService(CakeContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<CakeDto> GetCakes(CakeQuery cakeQuery)
        {
            var query = _dbContext.Cakes.AsQueryable();
            if (cakeQuery == null)
                return null;

            if (!string.IsNullOrWhiteSpace(cakeQuery.SearchTxt))
                query = query.Where(o => o.CakeName.Equals(cakeQuery.SearchTxt));
            //if (cakeQuery.Category.HasValue)
            //    query = from c in query
            //            join t in _dbContext.CakeTypes on c.CakettypeId equals t.Id
            //            where t.CakeCategory.Equals(cakeQuery.Category.Value)
            //            select c;
            return cakeQuery.ToPageList(query.Select(o => new CakeDto(o)));
        }

        public IList<CakeTypeDto> GetScenarios()
        {
            var scenarios = _dbContext.CakeTypes.AsEnumerable().Select(o => new CakeTypeDto(o)).ToList();
            return scenarios;
        }
    }
}