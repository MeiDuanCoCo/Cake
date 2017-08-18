using System.Linq;

namespace Cake.Dto
{
    public class PageQuery<T>
    {
        public int PageIndex { get; set; } = 1;
        private int PageSize { get; set; } = 10;
        IQueryable<T> Data { get; set; }

        public IQueryable<T> ToPageList(IQueryable<T> data)
        {
            if (data == null || !data.Any())
                return data;

            if (PageIndex <= 1) PageIndex = 1;
            if (PageSize < 0) PageSize = 10;
            return data.Skip((PageIndex - 1) * PageSize).Take(PageSize);
        }
    }
}