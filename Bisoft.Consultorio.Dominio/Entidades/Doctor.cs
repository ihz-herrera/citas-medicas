using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Entidades
{
    public class Doctor
    {

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }


       

        public Doctor(string cedula, string nombre, string email, string telefono)
        {
            Cedula =   String.IsNullOrEmpty(cedula) ? throw new ArgumentException("La cedula del doctor no es correcta") : cedula  ;
            Nombre = !string.IsNullOrEmpty(nombre) ? nombre : throw new ArgumentException("El nombre del cliente no es correcto");
            Email = !string.IsNullOrEmpty(email) ? email : throw new ArgumentException("El email del cliente no es correcto");
            
            if(!Int64.TryParse(telefono, out Int64 t) )
                     throw new ArgumentException("El telefono debe de ser numerico");
            
            Telefono = telefono;
        }

        override public string ToString()
        {
            return $"{Cedula},{Nombre},{Email},{Telefono}";
        }
    }
}
