using BlazorApp.Models;

namespace BlazorApp.Services
{
    public class ProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = await _http.GetFromJsonAsync<List<Product>>("https://fakestoreapi.com/products");
            return products ?? new List<Product>();
        }
    }
}
