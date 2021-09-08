using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Resta
    {
        static public int operate(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0)
                throw new InvalidOperationException("No se pueden restar valores negativos");
            return n1 - n2;
        }
    }
}
