using System.Text.Json;

public interface IFileService
{
    Task<JsonDocument> GetFileFromUrl(string url);
} 