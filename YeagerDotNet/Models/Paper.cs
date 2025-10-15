namespace YeagerDotNet.Models;

public record Paper(
    string Title,
    string Authors,
    string Venue,
    int Year,
    string Url,
    string PreviewUrl
);
