using BISoft.Consultorio.Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Repositorios
{
    public class DoctoresRepository:Repository<Doctor>
    {

        private string _path = "C:\\BaseDatos\\doctor.txt";

        public DoctoresRepository():base("C:\\BaseDatos\\")
        {
            
        }

        public DoctoresRepository(string path):base(path)
        {
            _path = path;
        }


        //public void GuardarDoctor(Doctor doctor)
        //{
        //    using (System.IO.StreamWriter file =
        //                    new System.IO.StreamWriter(_path, true))
        //    {
        //        file.WriteLine(doctor.ToString());
        //    }
        //}

        public List<Doctor> CargarDoctores()
        {

            var clientes = new List<Doctor>();

            using (System.IO.StreamReader file =
                                           new System.IO.StreamReader(_path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var doctor = new Doctor();
                    var datos = line.Split(',');
                    doctor.Cedula = datos[0];
                    doctor.Nombre = datos[1];
                    doctor.Email = datos[2];
                    doctor.Telefono = datos[3];

                    clientes.Add(doctor);
                }
            }

            return clientes;
        }


    }
}
