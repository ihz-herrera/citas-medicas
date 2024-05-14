using Azure.Core;
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

        public async  Task<List<Doctor>> CargarDoctores()
        {
            return await _repo.CargarDoctores();
        }

        public async Task<Doctor> GuardarDoctor(Doctor doctor)
        {
            await _repo.Guardar(doctor);
            return doctor;
        }
    }
}
