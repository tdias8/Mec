using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Context
{
    public class MecanicaContext: DbContext
    {
        public MecanicaContext(DbContextOptions<MecanicaContext> options)
            :base (options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }

    }
}
