using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Dominio.Entidades;
using BISoft.Consultorio.Aplicacion.Fabricas;
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

        public ClienteService(IClientesRepository repositorio)
        {
            _repo = repositorio;
        }

        public async Task<List<Cliente>> CargarClientes()
        {
            return  await _repo.CargarClientes();
        }


        public void GuardarCliente(Cliente cliente)
        { 
            _repo.Guardar(cliente);
            
        
        }


        public async Task<Cliente> GuardarCliente(string nombre, string email, int edad)
        {
            //Cargar Clientes en una coleccion
            var clientes = await _repo.CargarClientes();

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
            await _repo.Guardar(cliente);

            return cliente;

            
        }
    }
}
