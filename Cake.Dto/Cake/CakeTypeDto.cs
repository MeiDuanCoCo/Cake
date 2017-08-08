using Cake.Domain;
using Cake.Domain.Cake;

namespace Cake.Dto.Cake
{
    /// <summary>
    ///     蛋糕类型表
    /// </summary>
    public class CakeTypeDto
    {
        public CakeTypeDto(CakeType model)
        {
            Name = model.Name;
            Url = model.Url;
        }

        /// <summary>
        ///     蛋糕类别名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     链接地址
        /// </summary>
        public string Url { get; set; }
    }
}