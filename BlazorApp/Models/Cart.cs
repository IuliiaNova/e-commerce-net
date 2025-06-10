namespace BlazorApp.Models
{
    public class Cart
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public Client? Client { get; set; }

    public ICollection<CartProduct>? CartProducts { get; set; }
}

public class CartProduct
{
    public int CartId { get; set; }
    public Cart?  Cart { get; set; }

    public int ProductId { get; set; }
    public Product? Product { get; set; }

    public int Quantity { get; set; }
}
}