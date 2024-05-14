using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bisoft.Consultorio.Shared.Servicios
{

    public class Doctor
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }

    public class DoctoresService
    {
        public DoctoresService() { }

        public async Task CrearDoctor(string cedula, string nombre, string email, string telefono)
        {
            var httpClient = new HttpClient();

            //creo el objeto doctor
            var doctor = new Doctor
            {
                Cedula = cedula,
                Nombre = nombre,
                Email = email,
                Telefono = telefono
            };

            httpClient.BaseAddress = new Uri("https://localhost:7092/api/doctores");

            var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(doctor), System.Text.Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(httpClient.BaseAddress, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al crear el doctor");
            }
                
        }

        public async Task<IEnumerable<Doctor>> ConsultarDoctores()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync("https://localhost:7092/api/doctores");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var doctores = Newtonsoft.Json.JsonConvert
                    .DeserializeObject<IEnumerable<Doctor>>(content);

                return doctores;
            }
            else
            {
                throw new Exception("Error al consultar los doctores");
            }
        }

         
    }
}
