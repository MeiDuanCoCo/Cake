using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cake.Domain.Link
{
    /// <summary>
    /// 快捷链接表
    /// </summary>
    public class QuickLink : BaseObject
    {
        public QuickLink()
        {
            Available = true;
            QuickLinkItems = new List<QuickLinkItem>();
        }

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
        /// 是否可用
        /// </summary>
        public bool Available { get; set; }

        public virtual List<QuickLinkItem> QuickLinkItems { get; set; }
    }
}