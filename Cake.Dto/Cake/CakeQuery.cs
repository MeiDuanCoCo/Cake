using Cake.Domain.Cake;

namespace Cake.Dto.Cake
{
    /// <summary>
    ///     查询条件
    /// </summary>
    public class CakeQuery : PageQuery<CakeDto>
    {
        public string SearchTxt { get; set; }
        public CakeCategory? Category { get; set; }
    }
}