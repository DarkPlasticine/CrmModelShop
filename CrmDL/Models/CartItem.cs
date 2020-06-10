namespace CrmDL.Models
{
    public class CartItem:BaseObject
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Quantity { get; set; }
    }
}