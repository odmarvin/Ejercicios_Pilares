using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPilares3.Clases
{
    public class PagoConTransferencia : Pago
    {
        public override void ProcesarPago()
        {
            Console.WriteLine("Iniciando transferencia bancaria...");
        }
    }
}
