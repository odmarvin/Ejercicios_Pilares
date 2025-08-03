using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPilares1.Clases.Ejercicio1
{
    public class Vehiculo
    {
        private Boolean encendido = false;

        public void Encender()
        {
            if (!encendido)
            {
                encendido = true;
            }
        }
        public void Apagar()
        {
            if(encendido)
            {
                encendido = false;
            }
        }
        public bool estaEncendido()
        {
            return encendido;
        }

    }
}
