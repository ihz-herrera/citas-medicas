using BISoft.Consultorio.Presentacion.Contratos;
using BISoft.Consultorio.Presentacion.Entidades;
using BISoft.Consultorio.Presentacion.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisoft.Consultorio.Aplicacion.Servicio
{
    public class ClienteService
    {
        private readonly IClientesRepository _repo;

        public ClienteService(string repositorio)
        {
            _repo = ClientesContextFabrik.CrearClientesRespository(repositorio) ;
        }



        public void GuardarCliente(string nombre, string email, int edad)
        {
            //Consultar el ultimo id
            var id = _repo.CargarClientes().Count + 1;

            //Crear el cliente
            var cliente = new Cliente(id,nombre, email, edad);

            //Guardar el cliente
            _repo.Guardar(cliente);

            
        }
    }
}
