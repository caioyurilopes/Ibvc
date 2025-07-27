namespace Ibvc.Domain.DTOs.Enums;

public enum EstadoCivil
{
    Solteiro = 0,
    Casado = 1,
    Separado = 2,
    Divorciado = 3,
    Viuvo = 4,
    UniaoEstavel = 5
}

public static class EstadoCivilExtensions
{
    public static string ToDisplay(this EstadoCivil estadoCivil)
    {
        return estadoCivil switch
        {
            EstadoCivil.Solteiro => "Solteiro",
            EstadoCivil.Casado => "Casado",
            EstadoCivil.Separado => "Separado",
            EstadoCivil.Divorciado => "Divorciado",
            EstadoCivil.Viuvo => "Viúvo",
            EstadoCivil.UniaoEstavel => "União Estável"
        };
    }
}