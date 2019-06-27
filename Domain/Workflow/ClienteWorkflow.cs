using Domain.Commands;
using Domain.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Workflow
{
    public class ClienteWorkflow
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteWorkflow(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente AddCliente(ClienteCommand command)
        {
            Cliente cliente = new Cliente(command);
            _clienteRepository.AddCliente(cliente);

            return cliente;
        }

        public Cliente UpdateCliente(int id, ClienteCommand command)
        {
            Cliente cliente = _clienteRepository.GetCliente(id);

            if (cliente != null)
            {
                cliente.Update(command);
                _clienteRepository.UpdateCliente(cliente);
                return cliente;
            }

            return null;
        }

        public void DeleteCliente(int id)
        {
            _clienteRepository.DeleteCliente(id);
        }

    }
}
