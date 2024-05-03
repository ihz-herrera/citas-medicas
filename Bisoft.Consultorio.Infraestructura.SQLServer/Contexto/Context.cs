using BISoft.Consultorio.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Infraestructura.SQLServer.Contexto
{
    public class Context: DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             string connectionString = "server = .\\MSSQLServer01; Initial Catalog=ConsultorioDB; Trusted_Connection=true; Encrypt=false";
             optionsBuilder.UseSqlServer(connectionString);

            var cadena = "";

           


        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Doctor>().ToTable("Doctores");
            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);   
            modelBuilder.Entity<Doctor>().HasKey(d => d.Cedula);
        }


    }
}
