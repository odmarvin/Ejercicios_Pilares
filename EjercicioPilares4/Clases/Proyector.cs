using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPilares4.Clases
{
    public class Proyector : DispositivoSalida
    {
        public override void MostrarMensaje(string mensaje)
        {
            Console.WriteLine("Lanzando proyección: " + mensaje);
        }
    }
}
