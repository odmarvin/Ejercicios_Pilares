﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPilares2.Clases
{
    public class Gerente : Empleado
    {
        public void TomarDecision()
        {
            Console.WriteLine($"{Nombre} está tomando una decisión gerencial");
        }
    }
}
