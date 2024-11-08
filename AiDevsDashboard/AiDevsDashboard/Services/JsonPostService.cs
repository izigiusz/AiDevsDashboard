using System.Net.Http;
using System.Threading.Tasks;

public class JsonPostService : IJsonPostService
{
    private readonly HttpClient _httpClient;

    public JsonPostService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> PostJsonAsync(string url, string jsonContent)
    {
        var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(url, content);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
} 