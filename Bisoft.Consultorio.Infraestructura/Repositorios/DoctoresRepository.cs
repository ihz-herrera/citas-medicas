﻿using BISoft.Consultorio.Infraestructura.SQLServer.Contexto;
using BISoft.Consultorio.Infraestructura.Contratos;
using BISoft.Consultorio.Infraestructura.Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Infraestructura.Repositorios
{
    public class DoctoresRepository : IDoctoresRepository
    {

        private Context _context;

        public DoctoresRepository(Context context)
        {
            _context = context;
        }

        public List<Doctor> CargarDoctores()
        {
            var doctores = _context.Doctores.ToList();
            return doctores;
        }

        public void Guardar(Doctor doctor)
        {
            _context.Doctores.Add(doctor);
            _context.SaveChanges();
        }
    }
}