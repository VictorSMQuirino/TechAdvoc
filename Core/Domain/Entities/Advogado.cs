namespace TechAdvoc.Domain.Entities;

public class Advogado : Pessoa
{

    public ICollection<CasoJuridico>? CasosJuridicos { get; set; }

}
