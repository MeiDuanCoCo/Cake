using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.Domain.Cake
{
    /// <summary>
    /// 蛋糕
    /// </summary>
    public class Cake : BaseObject
    {
        /// <summary>
        /// 蛋糕名称
        /// </summary>
        [StringLength(128)]
        public string CakeName { get; set; }

        /// <summary>
        /// 蛋糕类型
        /// </summary>
        public Type CakeType { get; set; }
        /// <summary>
        /// 关系类型
        /// </summary>
        public Type RelationType { get; set; }
    }
}
