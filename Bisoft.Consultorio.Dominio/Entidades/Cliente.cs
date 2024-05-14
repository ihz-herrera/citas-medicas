using Bisoft.Consultorio.Dominio.Guards;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; private set; }

        //Propiedades de Navegación
        public virtual List<Cita> Citas { get; private set; } = new List<Cita>();


        public Cliente()
        {

        }

        public Cliente(int id, string nombre, string email, int edad)
        {
            Id = id.NotZero(nameof(id)).NotNegative(nameof(id));
            Nombre = nombre.LengthBetween(nameof(nombre), 25, 2);
            Email = email.NotNullOrEmpty(nameof(email));
            Edad = edad.NotNegative(nameof(edad));



        }


        public void CrearCita(Cita cita)
        {
            //Validar que el cliente no tenga una cita previa
            if (!(Citas is null))
            {

                var tieneCita = Citas.Any(c =>
                c.Fecha.Date == cita.Fecha.Date) ?
                 throw new InvalidOperationException("El cliente ya tiene una cita en ese horario") : false;
            }
            else
            {
                Citas = new List<Cita>();
            }

            Citas.Add(cita);

        }


        public Cita CrearCita(Cliente cliente, Doctor doctor, DateTime fecha)
        {
            var cita = new Cita()
            {
                Cliente = cliente,
                Fecha = fecha,
                Doctor = doctor
            };

            CrearCita(cita);

            return cita;
        }

     

        private void CambiarEdad(int edad)
        {
            Edad = edad.NotNegative(nameof(edad));
        }

        public override string ToString()
        {
            return $"{Id},{Nombre},{Email},{Edad}";
        }


    }
}
