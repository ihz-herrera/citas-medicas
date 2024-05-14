using BISoft.Consultorio.Infraestructura.Contexto;
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
    public class ClientesRepository : IClientesRepository
    {

        private Context _context;


        //Crear contructor
        public ClientesRepository(Context context)
        {
            //Inicializar el contexto
            _context = context;
        }




        public async Task<List<Cliente>> CargarClientes()
        {

            var clientes = await _context.Clientes.ToListAsync();

            return clientes;
        }

        public async Task<Cliente> ClienteById(int id)
        {
            return await _context.Clientes
                .FirstOrDefaultAsync(c=> c.Id ==  id);
        }

        public async Task Guardar(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);

            await _context.SaveChangesAsync();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
