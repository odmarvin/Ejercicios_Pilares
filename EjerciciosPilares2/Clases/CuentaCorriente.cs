using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPilares2.Clases
{
    public class CuentaCorriente : CuentaBancaria
    {
        public CuentaCorriente(int limiteInicial) : base(limiteInicial) { }

        public override double CalcularIntereses()
        {
            return saldo * 0.06;
        }
    }
}
