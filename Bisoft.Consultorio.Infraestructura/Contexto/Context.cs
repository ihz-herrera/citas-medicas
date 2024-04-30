using BISoft.Consultorio.Infraestructura.Entidades;
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

       
        public Context(DbContextOptions options):base(options)
        {
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
