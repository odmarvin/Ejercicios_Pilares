using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPilares3.Clases
{
    public class ReproducirMusica : ComandoVoz
    {
        public override void Ejecutar()
        {
            Console.WriteLine("Reproduciendo música.");
        }
    }
}
