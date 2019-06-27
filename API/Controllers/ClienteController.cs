using Domain.Commands;
using Domain.Contracts;
using Domain.Workflow;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/clientes")]
    public class ClienteController: ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ClienteWorkflow _clienteWorkflow;

        public ClienteController(IClienteRepository clienteRepository, ClienteWorkflow clienteWorkflow)
        {
            _clienteRepository = clienteRepository;
            _clienteWorkflow = clienteWorkflow;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteCommand command)
        {
            var cliente = _clienteWorkflow.AddCliente(command);
            return Ok(cliente);
        }

        [HttpPut, Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] ClienteCommand command)
        {
            var cliente = _clienteWorkflow.UpdateCliente(id, command);
            return Ok(cliente);
        }

        [HttpDelete, Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _clienteWorkflow.DeleteCliente(id);
            return Ok();
        }

        [HttpGet, Route("{id}")]
        public IActionResult GetCliente([FromRoute] int id)
        {
            var cliente = _clienteRepository.GetCliente(id);
            return Ok(cliente);
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var clientes = _clienteRepository.GetClientes();
            return Ok(clientes);
        }
    }
}
