﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisoft.Consultorio.Aplicacion.Dtos
{
    public record ClienteCreate
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }

       public override string ToString()
        {
            return $"{Nombre},{Edad},{Email}";
        }
    }
}
