using Application.InputModels;
using Application.ViewModels;

namespace Application.Interfaces;
public interface IDocumentoService
{
    public List<DocumentoViewModel> GetAll();
    public int Create(DocumentoInputModel documento);

}
