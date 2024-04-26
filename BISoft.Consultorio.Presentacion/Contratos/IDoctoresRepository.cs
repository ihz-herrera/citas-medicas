using BISoft.Consultorio.Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Contratos
{
    public interface IDoctoresRepository
    {

        void Guardar(Doctor doctor);
        List<Doctor> CargarDoctores();  

    }
}
