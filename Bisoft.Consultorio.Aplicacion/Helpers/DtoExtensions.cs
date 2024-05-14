using Bisoft.Consultorio.Aplicacion.Dtos;
using BISoft.Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisoft.Consultorio.Aplicacion.Helpers
{
    public static class DtoExtensions
    { 
        public static Doctor ToDoctor(this DoctorCreate doctorCreate)
        {
            var doctor = new Doctor(
                    doctorCreate.Cedula, doctorCreate.Nombre,
                    doctorCreate.Email, 
                    doctorCreate.Telefono.Replace("-",""));
            return doctor;
        }

        public static CitaDto AsDto(this Cita cita) {

            var dto = new CitaDto()
            {
                Id = cita.Id,
                Cedula = cita.Doctor?.Cedula??"Default",
                Doctor = cita.Doctor?.Nombre??"Default",
                ClienteId = cita.Cliente.Id,
                Cliente = cita.Cliente.Nombre,
                Fecha = cita.Fecha

            };

            return dto;

        }
    }
}
