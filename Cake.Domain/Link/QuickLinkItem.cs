using System.ComponentModel.DataAnnotations;

namespace Cake.Domain.Link
{
    /// <summary>
    /// 快捷链接集合表
    /// </summary>
    public class QuickLinkItem : BaseObject
    {
        /// <summary>
        ///     链接名
        /// </summary>
        [StringLength(128)]
        public string Name { get; set; }

        /// <summary>
        ///     链接地址
        /// </summary>
        [StringLength(256)]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        /// <summary>
        /// 快捷链接表Id
        /// </summary>
        public long QuickLinkId { get; set; }
    }
}