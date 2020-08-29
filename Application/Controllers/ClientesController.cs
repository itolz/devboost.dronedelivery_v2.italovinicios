using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devboost.dronedelivery.felipe.DTO.Models;
using devboost.dronedelivery.felipe.EF.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace devboost.dronedelivery.felipe.Controllers
{
    [Authorize("Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClientesController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository; 
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return Ok(await _clienteRepository.Listar()); 
        }

      
        [HttpPost]
        public async Task<ActionResult> PostCliente([FromBody] Cliente cliente)
        {
            await _clienteRepository.InserirCliente(cliente);
            return NoContent(); 
        }

        
    }
}
