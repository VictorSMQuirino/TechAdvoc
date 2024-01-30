namespace TechAdvoc.Domain.Entities;

public class Cliente : Pessoa
{
    public int CasoJuridicoId { get; set; }
    public CasoJuridico CasoJuridico { get; set; }
}
