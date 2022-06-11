namespace PriceProject.DAL.Models
{
    /// <summary>
    /// Описание продукта в конкретном магазине.
    /// </summary>
    public class ProductInShop
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        public int PRODUCT_ID { get; set; }

        /// <summary>
        /// Идентификатор магазина.
        /// </summary>
        public int SHOP_ID { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public int PRICE { get; set; }

        /// <summary>
        /// Примечание.
        /// </summary>
        public string? COMMENT { get; set; }

        /// <summary>
        /// Дата обновления.
        /// </summary>
        public DateTime UPDATE_DATE { get; set; } 
    }
}
