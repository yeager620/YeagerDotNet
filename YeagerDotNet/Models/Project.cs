namespace YeagerDotNet.Models;

public class Project
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? WebLink { get; set; }
    public string? PreviewPath { get; set; }
    public List<string>? Skills { get; set; }
    public string ButtonText { get; set; } = "View";
}
