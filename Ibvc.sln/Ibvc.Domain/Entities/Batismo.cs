namespace Ibvc.Domain.Entities;

public class Batismo
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string Pastor { get; set; } = string.Empty;
    public string Igreja { get; set; } = string.Empty;
}