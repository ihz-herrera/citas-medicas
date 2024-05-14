using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Infraestructura.Repositorios
{
    public class DoctoresTxtRepository : Repository<Doctor> , IDoctoresRepository
    {

        private string _path = "C:\\BaseDatos\\doctor.txt";

        public DoctoresTxtRepository() : base("C:\\BaseDatos\\")
        {

        }

        public DoctoresTxtRepository(string path) : base(path)
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

        public async Task<List<Doctor>> CargarDoctores()
        {

            var doctores = new List<Doctor>();

            using (StreamReader file =
                                           new StreamReader(_path))
            {
                string line;
                while ((line = await file.ReadLineAsync()) != null)
                {
                    var datos = line.Split(',');
                    var doctor = new Doctor(datos[0],
                        datos[1],datos[2], datos[3]);
                   

                    doctores.Add(doctor);
                }
            }

            return doctores;
        }

        public Task<Doctor> DoctorById(string cedula)
        {
            throw new NotImplementedException();
        }
    }
}
