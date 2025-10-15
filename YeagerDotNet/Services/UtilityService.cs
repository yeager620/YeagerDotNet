namespace YeagerDotNet.Services;

public class UtilityService
{
    public string FormatDateRange(DateOnly start, DateOnly? end)
    {
        return $"{start:MMM yyyy} - {(end?.ToString("MMM yyyy") ?? "Present")}";
    }

    public bool IsImageFile(string? path)
    {
        if (string.IsNullOrEmpty(path)) return false;
        var ext = Path.GetExtension(path).ToLowerInvariant();
        return new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".webp" }.Contains(ext);
    }

    public bool IsPdfFile(string? path)
    {
        if (string.IsNullOrEmpty(path)) return false;
        return Path.GetExtension(path).ToLowerInvariant() == ".pdf";
    }
}
