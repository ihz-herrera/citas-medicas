using BISoft.Consultorio.Presentacion.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Contexto
{
    public class Context: DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             string connectionString = "data source = C:\\BaseDatos\\consultorio.db";
             optionsBuilder.UseSqlite(connectionString);

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
