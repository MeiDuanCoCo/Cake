﻿using System.ComponentModel.DataAnnotations;

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
        public string Name { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        [StringLength(256)]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        /// <summary>
        /// 类型枚举 1-标题  
        /// </summary>
        public CakeTypeEnum CakeTypeEnum { get; set; }

        public long ParentId { get; set; }

        ///// <summary>
        /////     蛋糕类型
        ///// </summary>
        //public CakeCategory CakeCategory { get; set; }
    }
}