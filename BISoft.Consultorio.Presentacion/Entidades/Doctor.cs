using System;
using System.Collections.Generic;
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

        override public string ToString()
        {
            return $"{Cedula},{Nombre},{Email},{Telefono}";
        }
    }
}
