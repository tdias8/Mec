using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class ProfissionalCommand
    {
        public int? Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Telefone { get; protected set; }
        public string Endereco { get; protected set; }
        public string Cpf { get; protected set; }
    }
}
