using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bisoft.Consultorio.Presentacion.Servicios
{

    //internal record ClienteRequet(string Nombre, string Email, int Edad);


    public class Cliente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
    }

    public class ClienteRequest
    {
        internal string Nombre { get; private set; }
        internal string Email { get; private set; }
        internal int Edad { get; private set; }

        public ClienteRequest(string nombre, string email, int edad)
        {
            Nombre = nombre;
            Email = email;
            Edad = edad;
        }


    }


public class ClientesService
    {

        public async void GuardarCliente(string nombre, string email, int edad)
        {
            // Aquí se debería llamar a la api para guardar el cliente
            var httpClient = new HttpClient();

            var cliente = new ClienteRequest
            ( nombre, email, edad );


            var content  =  new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(cliente), System.Text.Encoding.UTF8, "application/json");

            await httpClient.PostAsync("https://localhost:7092/api/clientes"
                ,content);

           // await httpClient.PostAsJsonAsync("https://localhost:7092/api/clientes", cliente);


        }

        public async Task<IEnumerable<Cliente>> ConsultarClientes()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync("https://localhost:7092/api/clientes");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var clientes = Newtonsoft.Json.JsonConvert
                    .DeserializeObject<IEnumerable<Cliente>>(content);

                return clientes;
            }
            else
            {
                throw new Exception("Error al consultar los clientes");
            }
        }
    }
}
