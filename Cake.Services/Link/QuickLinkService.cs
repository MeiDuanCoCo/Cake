using System.Linq;
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