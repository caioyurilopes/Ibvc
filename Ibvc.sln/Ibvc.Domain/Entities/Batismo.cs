namespace Ibvc.Domain.Entities;

public class Batismo
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Data { get; set; }
    public string Pastor { get; set; } = string.Empty;
    public string Igreja { get; set; } = string.Empty;
}