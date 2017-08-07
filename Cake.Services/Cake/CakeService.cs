using Cake.Domain;
using Cake.Domain.Cake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.Services.Cake
{
    public class CakeService : BaseService, ICakeService
    {
        public CakeService(CakeContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Domain.Cake.Cake> GetCakes(CakeQuery cakeQuery)
        {
            var query = _dbContext.Cakes.AsQueryable();
            if (cakeQuery == null)
                return query;

            if (!string.IsNullOrWhiteSpace(cakeQuery.SearchTxt))
                query = query.Where(o => o.CakeName.Equals(cakeQuery.SearchTxt));
            if (cakeQuery.Category.HasValue)
                query = from c in query
                        join t in _dbContext.CakeTypes on c.CakettypeId equals t.Id
                        where t.CakeCategory.Equals(cakeQuery.Category.Value)
                        select c;
            return cakeQuery.ToPageList(query);
        }
    }
}
