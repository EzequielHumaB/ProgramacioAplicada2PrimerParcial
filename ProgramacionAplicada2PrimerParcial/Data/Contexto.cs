using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProgramacionAplicada2PrimerParcial.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=DESKTOP-B3FBQ4F;Database=ProgramacionAplicada2PrimerPacialDb;Trusted_Connection"));
        }
    }
}
