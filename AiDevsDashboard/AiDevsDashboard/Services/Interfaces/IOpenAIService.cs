public interface IOpenAIService
{
    Task<string> CompleteChat(string prompt);
} 