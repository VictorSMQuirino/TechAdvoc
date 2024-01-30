using TechAdvoc.Domain.Common;

namespace TechAdvoc.Domain.Entities;

public class CasoJuridico : BaseEntity
{
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    
    public int AdvogadoId { get; set; }

    public Advogado Advogado { get; set; }
    public ICollection<Documento>? Documentos { get; set; }
    public DateTime Abertura { get; set; }

    
}
