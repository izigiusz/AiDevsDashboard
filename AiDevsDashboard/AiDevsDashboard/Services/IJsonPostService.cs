public interface IJsonPostService
{
    Task<string> PostJsonAsync(string url, string jsonContent);
} 