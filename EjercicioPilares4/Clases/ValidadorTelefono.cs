using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPilares4.Clases
{
    public class ValidadorTelefono : IValidador
    {
        public bool EsValido(string dato)
        {
            return dato.Length == 8;
        }
    }
}
