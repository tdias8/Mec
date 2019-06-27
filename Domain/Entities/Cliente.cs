using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cliente: Pessoa
    {
        public DateTime? DataNascimento { get; private set; }
        public string Sexo { get; private set; }
        public string EstadoCivil { get; private set; }
        public bool Ativo { get; private set; }

        public Cliente()
        {

        }

        public Cliente(ClienteCommand command)
        {
            Nome = command.Nome;
            Email = command.Email;
            Telefone = command.Telefone;
            Endereco = command.Endereco;
            Cpf = command.Cpf;
            DataNascimento = command.DataNascimento;
            Sexo = command.Sexo;
            EstadoCivil = command.EstadoCivil;
            Ativo = true;
        }

        public void Update(ClienteCommand command)
        {
            Nome = command.Nome;
            Email = command.Email;
            Telefone = command.Telefone;
            Endereco = command.Endereco;
            Cpf = command.Cpf;
            DataNascimento = command.DataNascimento;
            Sexo = command.Sexo;
            EstadoCivil = command.EstadoCivil;
            Ativo = command.Ativo;
        }

    }
}
