using Domain.Contracts;
using Domain.Entities;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly MecanicaContext _context;

        public ProfissionalRepository(MecanicaContext context)
        {
            _context = context;
        }

        public void AddProfissional(Profissional profissional)
        {
            _context.Profissionais.Add(profissional);
            _context.SaveChanges();
        }

        public void AddProfissional(Profissional profissional)
        {
            throw new NotImplementedException();
        }

        public void DeleteProfissional(int id)
        {
            Profissional profissional = GetProfissional(id);
            _context.Profissionais.Remove(profissional);
        }

        public Profissional GetProfissional(int id)
        {
            return _context.Profissionais.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Profissional> GetProfissionais()
        {
            return _context.Profissionais.ToList();
        }

        public void UpdateProfissional(Profissional profissional)
        {
            _context.Profissionais.Update(profissional);
        }
    }
}