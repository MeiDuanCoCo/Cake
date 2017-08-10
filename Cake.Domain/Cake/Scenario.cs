using System;
using System.ComponentModel;

namespace Cake.Domain.Cake
{
    /// <summary>
    ///     蛋糕应用场景
    /// </summary>
    [Flags]
    public enum Scenario
    {
        /// <summary>
        ///     不限
        /// </summary>
        [Description("不限")] Unlimited = 0,

        /// <summary>
        ///     生日
        /// </summary>
        [Description("生日")] Birthday = 1,

        /// <summary>
        ///     婚礼
        /// </summary>
        [Description("婚礼")] Wedding = 2,

        /// <summary>
        ///     优惠
        /// </summary>
        [Description("优惠")] Concession = 4,

        /// <summary>
        ///     商店
        /// </summary>
        [Description("商店")] Store = 8
    }
}