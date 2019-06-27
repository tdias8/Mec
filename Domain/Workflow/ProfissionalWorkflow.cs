using Domain.Commands;
using Domain.Entities;
using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Workflow
{
    public class ProfissionalWorkflow
    {
        private readonly IProfisionalRepository _profissionalRepository;

        public ProfissionalWorkflow(IProfisionalRepository profisionalRepository)
        {
            _profissionalRepository = profisionalRepository;
        }

        public Profissional AddCliente(ProfissionalCommand command)
        {
            Profissional profissional = new Profissional(command);
            _profissionalRepository.AddProfissional(profissional);

            return profissional;
        }

        public Profissional UpdateProfissional(int id, ProfissionalCommand command)
        {
            Profissional profissional = _profissionalRepository.GetProfissional(id);

            if (profissional != null)
            {
                profissional.Update(command);
                _profissionalRepository.UpdateProfissional(profissional);
                return profissional;
            }

            return null;
        }

        public void DeleteProfissional(int id)
        {
            _profissionalRepository.DeleteProfissional(id);
        }

    }
}
