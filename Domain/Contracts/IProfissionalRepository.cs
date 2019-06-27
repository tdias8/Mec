using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Contracts
{
   public interface IProfissionalRepository
    {
        void AddProfissional(Profissional profissional);
        void UpdateProfissional(Profissional profissional);
        Profissional GetProfissional(int id);
        IEnumerable<Profissional> GetProfissional();
        void DeleteProfissional(int id);
    }
}
