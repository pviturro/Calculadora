using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Suma
    {
        public static int sum(int[] nums)
        {
            var total = 0;
            foreach (var n in nums)
            {
                if (n < 0)
                    throw new InvalidOperationException("No se pueden sumar números negativos");
                total += n;
            }
            return total;
        }
    }
}
