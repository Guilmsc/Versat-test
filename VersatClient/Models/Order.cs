using System.ComponentModel.DataAnnotations;

namespace VersatClient.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        [Required(ErrorMessage ="Product Required")]
        [StringLength(50)]
        public string Product { get; set; }
        [Required(ErrorMessage ="Price Required")]
        public decimal Price { get; set; }
        [Range(1,100)]
        public int Quantity { get; set; }

        public int ClientId { get; set; }

        public Order()
        {
        }

        public Order(int orderId, DateTime purchaseDate, string product, decimal price, int quantity, int clientId)
        {
            OrderId = orderId;
            PurchaseDate = purchaseDate;
            Product = product;
            Price = price;
            Quantity = quantity;
            ClientId = clientId;
        }
        public decimal TotalPrice()
        {
            return Price * Quantity;
        }
    }
}
