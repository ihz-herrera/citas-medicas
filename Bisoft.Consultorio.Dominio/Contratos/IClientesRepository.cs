using BISoft.Consultorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Dominio.Contratos
{
    public interface IClientesRepository
    {

        Task Guardar(Cliente cliente);
        Task<List<Cliente>> CargarClientes();
    }
}
