using Bisoft.Consultorio.Aplicacion.Dtos;
using Bisoft.Consultorio.Aplicacion.Servicio;
using BISoft.Consultorio.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Bisoft.Consultorio.API.Controllers
{

    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {

        private readonly ClienteService _clienteService;

        //Contructor
        public ClientesController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public  async Task<ActionResult<IEnumerable<Cliente>>> ObtenerClientes()
        {
            try
            {
                //Simulando un retardo de 30 segundos

                await Task.Delay(30000);

                return Ok( await _clienteService.CargarClientes());

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


    }
}
