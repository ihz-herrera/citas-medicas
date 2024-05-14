using BISoft.Consultorio.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Infraestructura.Contexto
{
    public class Context: DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Cita> Citas { get; set; }

       
        public Context(DbContextOptions options):base(options)
        {
        }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Doctor>().ToTable("Doctores");
            modelBuilder.Entity<Cita>().ToTable("Citas");

            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);   
            modelBuilder.Entity<Doctor>().HasKey(d => d.Cedula);

            //Configurar forengkey de clientes y citas
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Citas)
                .HasForeignKey(c => c.ClienteId);
            


        }


    }
}
