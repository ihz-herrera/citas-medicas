using BISoft.Consultorio.Infraestructura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Infraestructura.Contratos
{
    public interface IClientesRepository
    {

        void Guardar(Cliente cliente);
        List<Cliente> CargarClientes();
    }
}
