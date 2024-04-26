using BISoft.Consultorio.Presentacion.Contratos;
using BISoft.Consultorio.Presentacion.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Fabricas
{
    public class ClientesContextFabrik
    {

        public static IClientesRepository CrearClientesRespository(string bdType = "Txt")
        {
             switch (bdType)
            {
                case "Lite":
                     return new ClientesLiteRepository();
                case "Txt":
                     return new ClientesTxtRepository();
                case "MSSQL":
                    return new ClientesMSSQLRepository();
                default:
                    return new ClientesLiteRepository();
            };
        }

        public static IDoctoresRepository CrearDoctoresSQLRepository()
        {
            return new DoctoresLiteRepository();
        }


       


    }
}
