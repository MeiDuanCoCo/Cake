namespace Cake.Domain.Cake
{
    /// <summary>
    ///     查询条件
    /// </summary>
    public class CakeQuery : PageQuery<Cake>
    {
        public string SearchTxt { get; set; }
        public CakeCategory? Category { get; set; }
    }
}