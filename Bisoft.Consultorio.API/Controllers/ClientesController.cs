using Azure.Core;
using Bisoft.Consultorio.Aplicacion.Dtos;
using Bisoft.Consultorio.Aplicacion.Helpers;
using Bisoft.Consultorio.Aplicacion.Servicio;
using BISoft.Consultorio.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Bisoft.Consultorio.API.Controllers
{

    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {

        private readonly ClienteService _clienteService;
        private readonly ILogger<ClientesController> _logger;

        //Contructor
        public ClientesController(ClienteService clienteService, ILogger<ClientesController> logger)
        {
            _clienteService = clienteService;
            _logger = logger;
        }

        [HttpGet]
        public  async Task<ActionResult<IEnumerable<Cliente>>> ObtenerClientes()
        {
            try
            {
                //Simulando un retardo de 30 segundos

                await Task.Delay(5000);

                var result = await _clienteService.CargarClientes()
                    ;

                var r = result.FirstOrDefault().Citas.ToList();

                return Ok( result);

            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

            catch (Exception)
            {
                //Loggear el error
                return StatusCode(500, "Error en el servidor");
            }

            
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> CrearCliente(ClienteCreate cliente)
        {
            try
            {
                //servicio.GuardarCliente(cliente);
                var result = await _clienteService.GuardarCliente(cliente.Nombre, cliente.Email, cliente.Edad);

                return Ok(result);
            }

            catch (Exception)
            {

                return StatusCode(500, "Error en el servidor");
            }

        }

        [HttpGet ("{clienteId}/citas")]
        public async Task<ActionResult<List<Cita>>> ConsultarCitas(int clienteId)
        {
            try
            {

                _logger.LogInformation("Consultar Citas");

                Cliente cliente = await _clienteService.GetCliente(clienteId);

                var citas = from cita in cliente.Citas
                            select cita.AsDto();

                return Ok(citas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error Interno del Servidor");
            }
        }


        [HttpPost("{clienteId}/citas")]
        public async Task<ActionResult<Cita>> CrearCita([FromRoute]int clienteId, CitaCreate citaCreate)
        {

            try
            {
                var result = await _clienteService.CrearCita(clienteId, citaCreate);
               
                
                return Ok(result.AsDto());
                
                //return Ok(new{ Cliente=result.Cliente.Nombre,Doctor=result.Doctor.Nombre,
                //    Fecha = result.Fecha });
            }
            catch(ArgumentException ar)
            { return BadRequest(ar.Message); }
            catch (InvalidOperationException op)
            { return BadRequest(op.Message); }
            catch(KeyNotFoundException kn)
            { return BadRequest(kn.Message); }

            catch (Exception ex)
            {
                return StatusCode(500, "Error Interno del servidor");
            }
        }


    }
}
