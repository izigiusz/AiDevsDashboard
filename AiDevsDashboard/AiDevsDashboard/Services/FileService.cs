using System.Text.Json;

public class FileService : IFileService
{
    private readonly HttpClient _httpClient;

    public FileService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<JsonDocument> GetFileFromUrl(string url)
    {
        try
        {
            var response = await _httpClient.GetStringAsync(url);
            return JsonDocument.Parse(response);
        }
        catch (Exception ex)
        {
            throw new Exception("Błąd podczas pobierania pliku", ex);
        }
    }
} 