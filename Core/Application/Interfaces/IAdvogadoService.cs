using Application.InputModels;
using Application.ViewModels;

namespace Application.Interfaces;
public interface IAdvogadoService
{
    public List<AdvogadoViewModel> GetAll();
    public int Create(AdvogadoInputModel cliente);

}
