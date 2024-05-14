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
    public class DoctoresRepository : IDoctoresRepository
    {

        private Context _context;

        public DoctoresRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<Doctor>> CargarDoctores()
        {
            var doctores = await _context.Doctores.ToListAsync();
            return doctores;
        }

        public async Task<Doctor> DoctorById(string cedula)
        {
            return await _context.Doctores
                .FirstOrDefaultAsync(d=>d.Cedula == cedula); 
        }

        public async Task Guardar(Doctor doctor)
        {
            await _context.Doctores.AddAsync(doctor);
            await _context.SaveChangesAsync();
        }
    }
}
