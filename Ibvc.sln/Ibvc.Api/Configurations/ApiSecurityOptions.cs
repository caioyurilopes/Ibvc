namespace Ibvc.Api.Configurations;

public class ApiSecurityOptions
{
    public string HeaderName { get; set; } = "X-Api-Key";
    public string Key { get; set; } = string.Empty;
}