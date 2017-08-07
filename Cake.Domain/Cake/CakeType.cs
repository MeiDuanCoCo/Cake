using System.ComponentModel.DataAnnotations;

namespace Cake.Domain.Cake
{
    /// <summary>
    ///     蛋糕类型表
    /// </summary>
    public class CakeType : BaseObject
    {
        /// <summary>
        ///     蛋糕类别名称
        /// </summary>
        [StringLength(128)]
        public string CaketypeName { get; set; }

        /// <summary>
        ///     蛋糕类型
        /// </summary>
        public CakeCategory CakeCategory { get; set; }
    }
}