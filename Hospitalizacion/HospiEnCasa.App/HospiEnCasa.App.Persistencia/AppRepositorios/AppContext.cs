using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia 
{
    public class AppContext : DbContext
    {
        
        public DbSet<Enfermera> Enfermeras {get; set;}
        public DbSet<FamiliarDesignado> FamiliarDesignados {get; set;}
       // public DbSet<Genero> Generos {get; set;}
        public DbSet<Historia> Historias {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<SignosVital> SignosVitales {get; set;}
        public DbSet<SugerenciaCuidado> SugerenciaCuidados {get; set;}
        //public DbSet<TipoSigno> TipoSignos {get; set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEncasatData");

            }
        }
    }
}