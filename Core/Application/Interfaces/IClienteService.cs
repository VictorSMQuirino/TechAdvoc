using Application.InputModels;
using Application.ViewModels;

namespace Application.Interfaces;
public interface IClienteService
{
    public List<ClienteViewModel> GetAll();
    public int Create(ClienteInputModel cliente);

}
