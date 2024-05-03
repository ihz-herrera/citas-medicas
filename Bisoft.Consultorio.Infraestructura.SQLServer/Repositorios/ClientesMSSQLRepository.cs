using BISoft.Consultorio.Infraestructura.SQLServer.Contexto;
using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BISoft.Consultorio.Infraestructura.Repositorios
{
    public class ClientesMSSQLRepository : IClientesRepository
    {

        private Context _context;


        //Crear contructor
        public ClientesMSSQLRepository()
        {
            //Inicializar el contexto
            _context = new Context();
        }




        public async Task<List<Cliente>> CargarClientes()
        {

            var clientes = await _context.Clientes.ToListAsync();

            return clientes;
        }

        public async Task Guardar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);

            await _context.SaveChangesAsync();
        }

    }
}
