namespace PriceProject.DAL.Models
{
    /// <summary>
    /// Комментарий к продукту в конкретном магазине.
    /// </summary>
    public class ProductInShopComment
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Идентификатор продукта в конкретном магазине.
        /// </summary>
        public int PRODUCT_IN_SHOP_ID { get; set; }

        /// <summary>
        /// Комментарий.
        /// </summary>
        public string? COMMENT { get; set; }
    }
}
