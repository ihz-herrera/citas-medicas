using System;
using System.Collections.Generic;
using System.Text;

namespace Bisoft.Consultorio.Dominio.Guards
{
    public static class Guards
    {

        public static string NotNullOrEmpty(this string value, string name)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"El valor de {name} es incorrecto");
            }

            return value;
        }

        public static int NotNegative(this int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"El valor de {name} es incorrecto");
            }

            return value;
        }

        public static string IsNumeric(this string value, string name)
        {
            if (!Int64.TryParse(value, out Int64 t))
            {
                throw new ArgumentException($"El valor de {name} debe de ser numerico");
            }

            return value;
        }

        public static int NotZero(this int value, string name)
        {
            if (value == 0)
            {
                throw new ArgumentException($"El valor de {name} no puede ser cero");
            }

            return value;
        }

        public static string MaxLength(this string value, string name, int length)
        {
            if (value.Length > length)
            {
                throw new ArgumentException($"El valor de {name} debe de tener {length} caracteres");
            }

            return value;
        }

        public static string MinLength(this string value, string name, int length)
        {
            if (value.Length < length)
            {
                throw new ArgumentException($"El valor de {name} debe de tener {length} caracteres");
            }

            return value;
        }

        public static string LengthBetween(this string value, string name, int max,int min)
        {
            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentException($"El valor de {name} debe de tener entre {min} y {max} caracteres");
            }

            return value;
        }

    }
}
