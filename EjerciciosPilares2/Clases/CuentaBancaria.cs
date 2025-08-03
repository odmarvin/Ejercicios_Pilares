using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPilares2.Clases
{
    public class CuentaBancaria
    {
        protected double saldo = 0;
        protected int limiteRetiroDiario = 3000;

        public CuentaBancaria(int limiteInicial)
        {
            if (limiteInicial > 0)
            {
                limiteRetiroDiario = limiteInicial;
            }
            else
            {
                limiteRetiroDiario = 1000;
            }
        }

        public void Depositar(double monto)
        {
            if (monto > 0)
            {
                saldo += monto;
            }
        }

        public int LimiteRetiroDiario
        {
            get { return limiteRetiroDiario; }
            set
            {
                if (value < limiteRetiroDiario)
                {
                    limiteRetiroDiario = value;
                }
            }
        }

        public void Retirar(double monto)
        {
            if (monto > 0 && monto <= saldo && monto <= limiteRetiroDiario)
            {
                saldo -= monto;
            }
        }

        public double ObtenerSaldo()
        {
            return saldo;
        }

        public virtual double CalcularIntereses()
        {
            return 0; 
        }
    }

}
