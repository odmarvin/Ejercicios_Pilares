using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPilares3.Clases
{
    public class PagoConEfectivo : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Recibiendo efectivo...");
        }
    }
}
