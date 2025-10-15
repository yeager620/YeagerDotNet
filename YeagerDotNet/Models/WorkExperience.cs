namespace YeagerDotNet.Models;

public class WorkExperience
{
    public string Company { get; set; } = string.Empty;
    public string? Role { get; set; }
    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public string? Description { get; set; }
    public List<Project>? Projects { get; set; }
    public string? GraphicPath { get; set; }
}
