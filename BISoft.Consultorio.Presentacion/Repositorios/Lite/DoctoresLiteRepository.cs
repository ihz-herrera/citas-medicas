﻿using BISoft.Consultorio.Presentacion.Contexto;
using BISoft.Consultorio.Presentacion.Contratos;
using BISoft.Consultorio.Presentacion.Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISoft.Consultorio.Presentacion.Repositorios
{
    public class DoctoresLiteRepository : IDoctoresRepository
    {

        private Context _context;

        public DoctoresLiteRepository()
        {
            _context = new Context();
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
