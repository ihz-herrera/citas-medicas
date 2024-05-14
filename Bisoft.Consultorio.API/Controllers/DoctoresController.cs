using Bisoft.Consultorio.Aplicacion.Dtos;
using Bisoft.Consultorio.Aplicacion.Servicio;
using BISoft.Consultorio.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Bisoft.Consultorio.Aplicacion.Helpers;

namespace Bisoft.Consultorio.API.Controllers
{

    [ApiController]
    [Route("api/doctores")]
    public class DoctoresController : ControllerBase
    {
        private readonly DoctorService _doctoresService;

        public DoctoresController(DoctorService doctoresService)
        {
            _doctoresService = doctoresService;
        }


        [HttpPost]
        public async Task<ActionResult<Doctor>> CrearDoctor(DoctorCreate doctorCreate)
        {
            try
            {
                var doctor = doctorCreate.ToDoctor();
                var result = await _doctoresService.GuardarDoctor(doctor);

                return Ok(doctor);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error Interno del Servidor");
            }
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> ConsultarDoctores()
        {
            try
            {
                   var listaDoctores = await _doctoresService.CargarDoctores();
                   return Ok(listaDoctores);
            }
            catch (Exception)
            {
                //Log.Errror();
                return StatusCode(500, "Error Interno del Servidor");
            }
        }
    }
}
