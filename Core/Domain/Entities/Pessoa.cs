using TechAdvoc.Domain.Common;

namespace TechAdvoc.Domain.Entities;

public abstract class Pessoa : BaseEntity
{
    public string Nome { get; set; }
}
