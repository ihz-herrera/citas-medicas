﻿using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Infraestructura.Repositorios
{
    public class ClientesTxtRepository : Repository<Cliente>, IClientesRepository
    {
        private string _path = "C:\\BaseDatos\\cliente.txt";

        public ClientesTxtRepository(string path) : base(path)
        {
            _path = path;
        }

        public ClientesTxtRepository() : base("C:\\BaseDatos\\")
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

        public async Task<List<Cliente>> CargarClientes()
        {

            var clientes = new List<Cliente>();

            using (StreamReader file =
                                           new StreamReader(_path))
            {
                string line;
                while ((line = await file.ReadLineAsync()) != null)
                {
                    
                    var datos = line.Split(',');

                    var cliente = new Cliente(
                    int.Parse(datos[0])
                    ,datos[1]
                    ,datos[2]
                    ,int.Parse(datos[3])
                        );

                    clientes.Add(cliente);
                }
            }

            return clientes;
        }

        public Task<Cliente> ClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
