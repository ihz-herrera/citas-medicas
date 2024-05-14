using BISoft.Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Dominio.Contratos
{
    public interface IDoctoresRepository
    {

        Task Guardar(Doctor doctor);
        Task<List<Doctor>> CargarDoctores();
        Task<Doctor> DoctorById(string cedula);
    }
}
