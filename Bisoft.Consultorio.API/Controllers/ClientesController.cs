using Bisoft.Consultorio.Aplicacion.Dtos;
using Bisoft.Consultorio.Aplicacion.Servicio;
using BISoft.Consultorio.Infraestructura.Entidades;
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
        public IEnumerable<Cliente> ObtenerClientes()
        {
            return _clienteService.CargarClientes();
        }

        [HttpPost]
        public IActionResult CrearCliente(ClienteCreate cliente)
        {
            //servicio.GuardarCliente(cliente);
            var result = _clienteService.GuardarCliente(cliente.Nombre, cliente.Email, cliente.Edad);

            return Ok(result);
        }


    }
}
