using BISoft.Consultorio.Presentacion.Contratos;
using BISoft.Consultorio.Presentacion.Entidades;
using BISoft.Consultorio.Presentacion.Fabricas;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        public List<Cliente> CargarClientes()
        {
            return _repo.CargarClientes();
        }

        public void GuardarCliente(string nombre, string email, int edad)
        {
            //Cargar Clientes en una coleccion
            var clientes = _repo.CargarClientes();

            //Validar que el cliente no exista
            if (clientes.Any(c => c.Email == email))
            {
                throw new Exception("El cliente ya existe");
            }

            var id = 1;

            //Consultar el ultimo id
            if (clientes.Count != 0)
            {
                id = clientes.Max(e => e.Id) + 1;
            }
             

            //Crear el cliente
            var cliente = new Cliente(id,nombre, email, edad);

            //Guardar el cliente
            _repo.Guardar(cliente);

            
        }
    }
}
