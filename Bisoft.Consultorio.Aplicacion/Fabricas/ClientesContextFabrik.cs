using BISoft.Consultorio.Dominio.Contratos;

using BISoft.Consultorio.Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Aplicacion.Fabricas
{
    public static class ClientesContextFabrik
    {
        private static readonly Context _context;
      


        //public static IClientesRepository CrearClientesRespository(string bdType = "Txt")
        //{
        //     switch (bdType)
        //    {
        //        case "Lite":
        //             return new ClientesRepository(_context);
        //        case "Txt":
        //             return new ClientesRepository(_context);
        //        case "MSSQL":
        //            return new ClientesRepository(_context);
        //        default:
        //            return new ClientesRepository(_context);
        //    };
        //}

        //public static IDoctoresRepository CrearDoctoresSQLRepository()
        //{
        //    return new DoctoresRepository(_context);
        //}


       


    }
}
