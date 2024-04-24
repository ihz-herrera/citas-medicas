using BISoft.Consultorio.Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Repositorios
{
    public class ClientesRepository: Repository<Cliente>
    {
        private string _path = "C:\\BaseDatos\\cliente.txt";

        public ClientesRepository(string path):base(path)
        {
            _path = path;
        }

        public ClientesRepository():base("C:\\BaseDatos\\")
        {
            
        }

        //public  void GuardarCliente(Cliente cliente)
        //{
        //    using (System.IO.StreamWriter file =
        //                    new System.IO.StreamWriter(_path, true))
        //    {
        //        file.WriteLine(cliente.ToString());
        //    }
        //}

        public List<Cliente> CargarClientes()
        {

            var clientes = new List<Cliente>();

            using (System.IO.StreamReader file =
                                           new System.IO.StreamReader(_path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var cliente = new Cliente();
                    var datos = line.Split(',');
                    cliente.Id = int.Parse(datos[0]);
                    cliente.Nombre = datos[1];
                    cliente.Email = datos[2];
                    cliente.Edad = int.Parse(datos[3]);

                    clientes.Add(cliente);
                }
            }

            return clientes;
        }

    }
}
