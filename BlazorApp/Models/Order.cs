namespace BlazorApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? Status { get; set; } 

        public int ClientId { get; set; }
        public Client? Client { get; set; }

        public ICollection<OrderProduct>? OrderProducts { get; set; }
    }

    public class OrderProduct
    {
        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
