using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Dominio.Entidades;
using BISoft.Consultorio.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisoft.Consultorio.Aplicacion.Servicio
{
    public class DoctorService
    {
        private readonly IDoctoresRepository _repo;

        public DoctorService(IDoctoresRepository repository)
        {
            _repo = repository;
        }

        public List<Doctor> CargarDoctores()
        {
            return _repo.CargarDoctores();
        }

        public void GuardarDoctor(Doctor doctor)
        {
            _repo.Guardar(doctor);
        }
    }
}
