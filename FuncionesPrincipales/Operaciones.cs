﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesPrincipales
{
    public class Operaciones
    {
        public double suma(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double factorial (int num)
        {
            double fac = 1;
            for(int i = 1; i <= num; i++)
            {
                fac = fac * i;
            }
            return fac;
        }
    }
}
