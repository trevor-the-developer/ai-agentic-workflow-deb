namespace FreelanceAI.Core.Models;

public record GenerateRequest(
    string Prompt,
    int? MaxTokens = null,
    decimal? Temperature = null,
    string? Model = null,
    List<string>? StopSequences = null
)
{
    // Parameterless constructor for model binding
    public GenerateRequest() : this("")
    {
    }
}