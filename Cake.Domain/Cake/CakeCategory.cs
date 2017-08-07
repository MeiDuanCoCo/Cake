using System.ComponentModel;

namespace Cake.Domain.Cake
{
    /// <summary>
    ///     蛋糕类别
    /// </summary>
    public enum CakeCategory
    {
        /// <summary>
        ///     不同类别
        /// </summary>
        [Description("不同类别")] Category = 1,

        /// <summary>
        ///     不同折扣
        /// </summary>
        [Description("不同折扣")] Discount = 2,

        /// <summary>
        ///     不同味道
        /// </summary>
        [Description("不同味道")] Flavour = 4,

        /// <summary>
        ///     不同重量
        /// </summary>
        [Description("不同重量")] Weight = 8,

        /// <summary>
        ///     不同颜色
        /// </summary>
        [Description("不同颜色")] Color = 16
    }
}