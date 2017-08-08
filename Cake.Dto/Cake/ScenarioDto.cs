using System.Collections.Generic;
using Cake.Domain;
using Cake.Domain.Cake;

namespace Cake.Dto.Cake
{
    /// <summary>
    ///     蛋糕应用场景
    /// </summary>
    public class ScenarioDto
    {
        public ScenarioDto(Scenario model)
        {
            ScenarioName = model.ScenarioName;

            CakeTitles = new List<CakeTypeDto>();
            CakeTypes = new List<CakeTypeDto>();
        }

        /// <summary>
        ///     蛋糕应用场景名称
        /// </summary>
        public string ScenarioName { get; set; }

        /// <summary>
        ///     类别标题
        /// </summary>
        public List<CakeTypeDto> CakeTitles { get; set; }

        /// <summary>
        ///     类别
        /// </summary>
        public List<CakeTypeDto> CakeTypes { get; set; }
    }
}