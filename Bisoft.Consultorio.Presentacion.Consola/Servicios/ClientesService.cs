using BISoft.Consultorio.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;

namespace Bisoft.Consultorio.Presentacion.Servicios
{

    internal record ClienteRequet(string Nombre, string Email, int Edad);

    //internal record ClienteRequest()
    //{
    //    internal string Nombre { get; init; }
    //    internal string Email { get; init; }
    //    internal int Edad { get; init; }

    //    internal ClienteRequest(string nombre, string email, int edad)
    //    {
    //        Nombre = nombre;
    //        Email = email;
    //        Edad = edad;
    //    }

     
    //}
   

    public class ClientesService
    {

        public async void GuardarCliente(string nombre, string email, int edad)
        {
            // Aquí se debería llamar a la api para guardar el cliente
            var httpClient = new HttpClient();

            var cliente = new ClienteRequet
            (Nombre: nombre, Edad: edad ,Email: email
            );

            await httpClient.PostAsJsonAsync("https://localhost:7092/api/clientes", cliente);


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
