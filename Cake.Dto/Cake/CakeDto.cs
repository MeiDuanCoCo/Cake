namespace Cake.Dto.Cake
{
    public class CakeDto
    {
        /// <summary>
        ///     蛋糕名称
        /// </summary>
        public string Name { get; set; }

        public CakeDto(Domain.Cake.Cake cake)
        {
            Name = cake.CakeName;
        }
    }
}
