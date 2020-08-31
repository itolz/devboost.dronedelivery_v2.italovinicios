using devboost.dronedelivery.felipe.DTO.Constants;
using devboost.dronedelivery.felipe.DTO.Models;
using devboost.dronedelivery.felipe.EF.Data;
using devboost.dronedelivery.felipe.EF.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devboost.dronedelivery.felipe.EF.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;
        private readonly string _connectionString;

        public ClienteRepository(DataContext context,
            IConfiguration configuration)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString(ProjectConsts.CONNECTION_STRING_CONFIG);
        }

        public async Task InserirCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cliente>> Listar()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task<Cliente> Selecionar(int Id)
        {
            return await _context.Cliente.FindAsync(Id);
        }
    }
}
