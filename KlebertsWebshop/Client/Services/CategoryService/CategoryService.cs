using System.Net.Http.Json;

namespace KlebertsWebshop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public List<Category> Categories { get; set; } = new();

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
            if (response != null && response.Data != null)
                Categories = response.Data;
        }
    }
}
