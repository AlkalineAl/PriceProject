namespace PriceProject.DAL.Models
{
    /// <summary>
    /// Продукт.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string? NAME { get; set; }

        /// <summary>
        /// Идентификатор группы.
        /// </summary>
        public int GROUP_ID { get; set; }
    }
}
