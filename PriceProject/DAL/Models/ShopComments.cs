namespace PriceProject.DAL.Models
{
    /// <summary>
    /// Комментарии к магазинам.
    /// </summary>
    public class ShopComments
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Идентификатор магазина.
        /// </summary>
        public int SHOP_ID { get; set; }

        /// <summary>
        /// Комментарий.
        /// </summary>
        public string? COMMENT { get; set; }
    }
}
