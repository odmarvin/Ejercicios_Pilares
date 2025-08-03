using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPilares2.Clases
{
    public class Desarrollador : Empleado
    {
        public void Programar()
        {
            Console.WriteLine($"{Nombre} está programando");
        }
    }
}
