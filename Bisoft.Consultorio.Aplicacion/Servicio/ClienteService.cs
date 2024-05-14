using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Dominio.Entidades;
using BISoft.Consultorio.Aplicacion.Fabricas;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bisoft.Consultorio.Aplicacion.Dtos;
using Microsoft.Identity.Client.Extensibility;

namespace Bisoft.Consultorio.Aplicacion.Servicio
{
    public class ClienteService
    {
        private readonly IClientesRepository _repo;
        private readonly IDoctoresRepository _doctorRepo;

        public ClienteService(IClientesRepository repositorio, IDoctoresRepository doctorRepo)
        {
            _repo = repositorio;
            _doctorRepo = doctorRepo;
        }

        public async Task<List<Cliente>> CargarClientes()
        {
            return  await _repo.CargarClientes();
        }

        public async Task<Cita> CrearCita(int clienteId, CitaCreate citaCreate)
        {

            //var cliente = (await _repo.CargarClientes())
            //    .Where(c=>
            //        c.Id ==  clienteId).FirstOrDefault();

            var cliente = await _repo.ClienteById(clienteId);

            if(cliente is null)
            {
                throw new KeyNotFoundException("El cliente no esta regitrado");

            }

            //Validar que exista el Doctor
            var doctor = await _doctorRepo
                .DoctorById(citaCreate.Cedula);

            if (doctor is null)
                throw new ArgumentException("El doctor no existe.");

            //Validar disponibilidad del doctor
            var disponibilidad = doctor.Citas?
                .Where(c=> c.Fecha.Date == citaCreate.Fecha.Date)
                .FirstOrDefault();

            if (disponibilidad is not null)
                throw new InvalidOperationException("No puede reservar una cita en la fecha solicitada.");


            //var cita =  new Cita()
            //{

            //    Cliente = cliente,
            //    Doctor = doctor,
            //    Fecha = citaCreate.Fecha

            //}
            //;

            //cliente.Citas.Add(cita);


            var cita = cliente.CrearCita(cliente,doctor,citaCreate.Fecha);

            await  _repo.SaveChanges();

            return cita;    

        }

        public async Task<Cliente> GetCliente(int clienteId)
        {
           return  await _repo.ClienteById(clienteId);
        }

        public async Task GuardarCliente(Cliente cliente)
        { 
            await _repo.Guardar(cliente);
            
        
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
