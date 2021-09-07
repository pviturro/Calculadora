using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Division
    {

        public static DatosDivision division(int n1, int n2)
        {
            return new DatosDivision(n1, n2);
        }

    }
    public struct DatosDivision
    {
        public int resto;
        public int resultado;
        public DatosDivision(int n1, int n2)
        {
            this.resto = n1 % n2;
            this.resultado = n1 / n2;
        }
    }
}
