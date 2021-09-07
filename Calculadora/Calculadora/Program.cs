using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = PruebaDivision(15,0);
            Console.WriteLine(n);
        }

        private static int PruebaDivision(int v1, int v2)
        {
            return v1 / v2;
        }
    }
}
