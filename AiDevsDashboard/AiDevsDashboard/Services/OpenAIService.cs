using OpenAI.Chat;

public class OpenAIService : IOpenAIService
{
    private readonly ChatClient _client;

    public OpenAIService()
    {
        _client = new ChatClient(
            model: "gpt-4",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );
    }

    public async Task<string> CompleteChat(string prompt)
    {
        try
        {
            var response = await _client.CompleteChatAsync(prompt);
            return response.Value.Content[0].Text;
        }
        catch (Exception ex)
        {
            // Tutaj możesz dodać logowanie błędów
            throw new Exception("Błąd podczas komunikacji z OpenAI", ex);
        }
    }
} 