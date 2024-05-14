using BISoft.Consultorio.Infraestructura.Contexto;
using BISoft.Consultorio.Dominio.Contratos;
using BISoft.Consultorio.Dominio.Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BISoft.Consultorio.Infraestructura.Repositorios
{
    public class DoctoresLiteRepository : IDoctoresRepository
    {

        private Context _context;

        public DoctoresLiteRepository()
        {
            _context = new Context();
        }

        public async Task<List<Doctor>> CargarDoctores()
        {
            var doctores = await _context.Doctores.ToListAsync();
            return doctores;
        }

        public Task<Doctor> DoctorById(string cedula)
        {
            throw new NotImplementedException();
        }

        public async Task Guardar(Doctor doctor)
        {
            await _context.Doctores.AddAsync(doctor);
            await _context.SaveChangesAsync();
        }
    }
}
