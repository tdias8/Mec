using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Profissional: Pessoa
    {
        public Profissional()
        {

        }
        public Profissional(ProfissionalCommand command)
        {
            Nome = command.Nome;
            Email = command.Email;
            Telefone = command.Telefone;
            Endereco = command.Endereco;
            Cpf = command.Cpf;
            
        }

        public void Update(ProfissionalCommand command)
        {
            Nome = command.Nome;
            Email = command.Email;
            Telefone = command.Telefone;
            Endereco = command.Endereco;
            Cpf = command.Cpf;
           
        }
    }
}
