using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisoft.Consultorio.Aplicacion.Dtos
{
    public record CitaCreate
    {
        public DateTime Fecha { get; set; }
        public string Cedula { get; set; }

    }
}
