using System.Runtime.InteropServices;
using Application.InputModels;
using Application.Interfaces;
using Application.ViewModels;
using TechAdvoc.Domain.Entities;
using TechAdvoc.Domain.Interfaces;

namespace Application.Services;
public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository){
        _clienteRepository = clienteRepository;
    }

    public List<ClienteViewModel> GetAll()
    {
        return _clienteRepository.GetAll();
    }

    public int Create(ClienteInputModel cliente)
    {
        var _Cliente = new Cliente{
            Nome = cliente.Nome,
        };
        _clienteRepository.Create(_Cliente);
        return _Cliente.Id;
    }
}
