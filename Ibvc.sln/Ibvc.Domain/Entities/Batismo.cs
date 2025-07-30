namespace Ibvc.Domain.Entities;

public class Batismo
{
    public int Id { get; set; }
    public DateTime Data { get; set; }

    public string? PastorNomeManual { get; set; } = string.Empty; // Informar pastor manualmente //
    
    // Selecionar pastor //
    public int? PastorId { get; set; }
    public Usuario? Pastor { get; set; }
    // ----------------- //
    
    public string Igreja { get; set; } = string.Empty;
}