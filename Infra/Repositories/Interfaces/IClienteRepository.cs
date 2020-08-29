using devboost.dronedelivery.felipe.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace devboost.dronedelivery.felipe.EF.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> Listar();
        Task InserirCliente(Cliente cliente);
    }
}
