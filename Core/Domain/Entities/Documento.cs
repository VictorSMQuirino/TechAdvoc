using TechAdvoc.Domain.Common;

namespace TechAdvoc.Domain.Entities;

public class Documento : BaseEntity
{
    public string Descricao { get; set; }

    public int CasoJuridicoId {get; set;}

     public CasoJuridico CasoJuridico { get; set; }
}
