using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface IClienteRepository
    {
        void AddCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        Cliente GetCliente(int id);
        IEnumerable<Cliente> GetClientes();
        void DeleteCliente(int id);
    }
}
