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
    [Route("api/profissionais")]
    public class ProfissionalController : ControllerBase
    {
        private readonly IProfissionalRepository _profissionalRepository;
        private readonly ProfissionalWorkflow _profissionalWorkflow;

        public ProfissionalController(IProfissionalRepository profissionalRepository, ProfissionalWorkflow profissionalWorkflow)
        {
            _profissionalRepository = profissionalRepository;
            _profissionalWorkflow = profissionalWorkflow;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteCommand command)
        {
            var cliente = _profissionalWorkflow.AddCliente(command);
            return Ok(cliente);
        }

        [HttpPut, Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] ClienteCommand command)
        {
            var cliente = _profissionalWorkflow.UpdateCliente(id, command);
            return Ok(cliente);
        }

        [HttpDelete, Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _profissionalWorkflow.DeleteProfissional(id);
            return Ok();
        }

        [HttpGet, Route("{id}")]
        public IActionResult GetProfissional([FromRoute] int id)
        {
            var profissional = _profissionalRepository.GetProfissional(id);
            return Ok(profissional);
        }

        [HttpGet]
        public IActionResult GetProfissional()
        {
            var profissionais = _profissionalRepository.GetProfissionais();
            return Ok(profissionais);
        }
    }
}
