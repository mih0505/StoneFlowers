using Domain.Common;
using Domain.ProductModels;

namespace Domain.OrderModels
{
    public class OrderProduct : BaseModel
    {
        /// <summary>
        /// Договор
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Группа товара
        /// </summary>
        public int Group { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public Product Product { get; set; }
        
        /// <summary>
        /// Количество товара
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Цена закупа
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Цена реализации
        /// </summary>
        public decimal SalePrice { get; set; }        
    }
}
