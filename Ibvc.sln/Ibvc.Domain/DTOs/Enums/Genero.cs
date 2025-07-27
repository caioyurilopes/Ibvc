namespace Ibvc.Domain.DTOs.Enums;

public enum Genero
{
    Masculino = 0,
    Feminino = 1
}

public static class GeneroExtensions
{
    public static string ToDisplay(this Genero genero)
    {
        return genero switch
        {
            Genero.Masculino => "Masculino",
            Genero.Feminino => "Feminino"
        };
    }
}