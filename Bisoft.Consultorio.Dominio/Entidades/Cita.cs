using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Dominio.Entidades
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Doctor Doctor { get; set; }

       
        public int ClienteId { get; set; }
        public string DoctorCedula { get; set; }
        public Cita() { }

    }
}
