using System.Linq;
using Cake.Domain.Link;

namespace Cake.Services.Link
{
    public interface IQuickLinkService
    {
        IQueryable<QuickLink> GetLinks();
    }
}