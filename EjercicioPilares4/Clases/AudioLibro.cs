using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPilares4.Clases
{
    public class AudioLibro : ArchivoMultimedia
    {
        public override void Reproducir()
        {
            Console.WriteLine("Reproduciendo audiolibro...");
        }
    }
}
