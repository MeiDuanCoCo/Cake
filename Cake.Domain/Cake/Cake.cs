using System;
using System.ComponentModel.DataAnnotations;

namespace Cake.Domain.Cake
{
    /// <summary>
    ///     蛋糕表
    /// </summary>
    public class Cake : BaseObject
    {
        /// <summary>
        ///     蛋糕名称
        /// </summary>
        [StringLength(128)]
        public string CakeName { get; set; }

        /// <summary>
        ///     蛋糕类型表Id
        /// </summary>
        public long CakettypeId { get; set; }

        /// <summary>
        ///     蛋糕应用场景表Id
        /// </summary>
        public long ScenarioId { get; set; }
    }
}