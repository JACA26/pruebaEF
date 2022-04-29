using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaEB.Modelo
{
    public class DB: DbContext
    {
        public DbSet<PersonaModel> Personas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source = DESKTOP-9B888EI\SQLDEV;Database=ef_test; Integrated Security = True");
                
        }
    }
}
