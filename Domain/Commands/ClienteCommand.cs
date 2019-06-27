using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class ClienteCommand
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public bool Ativo { get; set; }
    }
}
