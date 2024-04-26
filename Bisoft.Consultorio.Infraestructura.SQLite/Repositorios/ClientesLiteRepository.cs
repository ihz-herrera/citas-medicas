using BISoft.Consultorio.Presentacion.Contexto;
using BISoft.Consultorio.Presentacion.Contratos;
using BISoft.Consultorio.Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Repositorios
{
    public class ClientesLiteRepository : IClientesRepository
    {

        private Context _context;


        //Crear contructor
        public ClientesLiteRepository()
        {
            //Inicializar el contexto
            _context = new Context();
        }




        public List<Cliente> CargarClientes()
        {

            var clientes = _context.Clientes.ToList();

            return clientes;
        }

        public void Guardar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);

            _context.SaveChanges();
        }

    }
}
