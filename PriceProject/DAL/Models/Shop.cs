namespace PriceProject.DAL.Models
{
    /// <summary>
    /// Магазин.
    /// </summary>
    public class Shop
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
        /// Координаты.
        /// </summary>
        public string? COORDINATES { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string? DESCRIPTION { get; set; }
    }
}
