using Bisoft.Consultorio.Aplicacion.Dtos;
using BISoft.Consultorio.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text;

namespace Bisoft.Consultorio.API.Controllers
{
    [ApiController]
    public class TestCSVController : ControllerBase
    {
        [HttpGet("download")]
        public IActionResult DownloadCsv()
        {
            // Crear una lista de objetos en memoria
            var objects = new List<ClienteCreate>
        {
            new ClienteCreate {  Nombre = "Object 1", Edad=20, Email = "object_1@gmail.com"},
            new ClienteCreate {  Nombre = "Object 2", Edad=20,Email = "object_2@gmail.com" },
            // Agrega más objetos según sea necesario
        };

            // Generar el contenido CSV
            var csv = GenerateCsv(objects);

            // Retornar el archivo CSV
            var bytes = Encoding.UTF8.GetBytes(csv);
            var result = new FileContentResult(bytes, "text/csv")
            {
                FileDownloadName = "data.csv"
            };

            return result;
        }

        private string GenerateCsv(IEnumerable<ClienteCreate> objects)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Nombre,Edad,Email");

            foreach (var obj in objects)
            {
                sb.AppendLine(obj.ToString());
            }

            return sb.ToString();
        }
    }
}
