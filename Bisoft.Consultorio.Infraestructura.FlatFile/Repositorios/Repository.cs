using BISoft.Consultorio.Infraestructura.Entidades;
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


        public void Guardar(TEntity entidad)
        {
            var tipo = entidad.GetType().Name;

            using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter($"{_path}//{tipo}.txt", true))
            {
                file.WriteLine(entidad.ToString());
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
