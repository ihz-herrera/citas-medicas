using Bisoft.Consultorio.Dominio.Guards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; private set; }


        public Cliente()
        {

        }


        public Cliente(int id, string nombre, string email, int edad)
        {
            Id =  id.NotZero(nameof(id)).NotNegative(nameof(id));
            Nombre = nombre.LengthBetween(nameof(nombre),25,2);
            Email = email.NotNullOrEmpty(nameof(email));
            Edad = edad.NotNegative(nameof(edad));
                
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
