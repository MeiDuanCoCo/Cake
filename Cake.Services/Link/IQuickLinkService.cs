using Cake.Domain.Link;
using System.Collections.Generic;
using System.Linq;

namespace Cake.Services.Link
{
    public interface IQuickLinkService
    {
        IQueryable<QuickLink> GetLinks();
    }
}
