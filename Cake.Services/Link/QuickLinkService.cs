using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Domain;
using Cake.Domain.Link;

namespace Cake.Services.Link
{
    public class QuickLinkService : BaseService, IQuickLinkService
    {
        public QuickLinkService(CakeContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<QuickLink> GetLinks()
        {
            var links = _dbContext.QuickLinks.Where(o => o.Available);
            return links;
        }
    }
}
