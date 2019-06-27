using Domain.Contracts;
using Domain.Entities;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly MecanicaContext _context;

        public ClienteRepository(MecanicaContext context)
        {
            _context = context;
        }

        public void AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void DeleteCliente(int id)
        {
            Cliente cliente = GetCliente(id);
            _context.Clientes.Remove(cliente);
        }

        public Cliente GetCliente(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _context.Clientes.ToList();
        }

        public void UpdateCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
        }
    }
}
