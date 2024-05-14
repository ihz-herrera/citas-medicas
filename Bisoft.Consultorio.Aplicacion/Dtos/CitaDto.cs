using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisoft.Consultorio.Aplicacion.Dtos
{
    public class CitaDto
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Doctor { get; set; }
        public int ClienteId { get; set; }
        public string Cliente { get; set;}
        public DateTime Fecha { get; set; }
    }
}
