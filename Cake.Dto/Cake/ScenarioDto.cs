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

            TypeDtos = new List<CakeTypeDto>();
        }

        /// <summary>
        ///     蛋糕应用场景名称
        /// </summary>
        public string ScenarioName { get; set; }

        /// <summary>
        ///     类别
        /// </summary>
        public List<CakeTypeDto> TypeDtos { get; set; }
    }
}