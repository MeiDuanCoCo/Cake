using System.ComponentModel.DataAnnotations;

namespace Cake.Domain.Cake
{
    /// <summary>
    ///     蛋糕应用场景表
    /// </summary>
    public class Scenario : BaseObject
    {
        /// <summary>
        ///     蛋糕应用场景名称
        /// </summary>
        [StringLength(128)]
        public string ScenarioName { get; set; }
    }
}