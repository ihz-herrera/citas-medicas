using BISoft.Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Infraestructura.Repositorios
{
    //Repositorio Generico
    public class Repository <TEntity>
    {
        private string _path ;

        public Repository(string path)
        {
            _path = path;
        }


        public async Task Guardar(TEntity entidad)
        {
            var tipo = entidad.GetType().Name;

            using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter($"{_path}//{tipo}.txt", true))
            {
               await file.WriteLineAsync(entidad.ToString());
            }
        }


        //Metodo Generico para cargar datos
        //public void Guardar<TEntity>(TEntity entidad)
        //{
        //    var tipo = entidad.GetType().Name;

        //    using (System.IO.StreamWriter file =
        //                    new System.IO.StreamWriter($"{_path}//{tipo}.txt", true))
        //    {
        //        file.WriteLine(entidad.ToString());
        //    }
        //}

    }
}
