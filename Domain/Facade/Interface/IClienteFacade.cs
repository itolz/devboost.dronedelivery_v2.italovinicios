using devboost.dronedelivery.felipe.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace devboost.dronedelivery.felipe.Facade.Interface
{
    public interface IClienteFacade
    {
        Task<List<Cliente>> GetClientesAsync();
    }
}
