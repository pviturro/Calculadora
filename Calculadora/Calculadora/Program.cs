using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Primer valor");
            string s1 = Console.ReadLine();
            Console.WriteLine("Operación (+ - * /)");
            var s = Console.ReadLine();
            Console.WriteLine("Segundo valor");
            var s2 = Console.ReadLine();
            int n1 = 0;
            int n2 = 0;
            Int32.TryParse(s1, out n1);
            Int32.TryParse(s2, out n2);
            if (s.Equals("+"))
                Console.WriteLine(Suma.operate(new int[] { n1, n2 }));
            else if (s.Equals("-"))
                Console.WriteLine(Resta.operate(n1, n2));
            else if (s.Equals("*"))
                Console.WriteLine(Multiplicacion.operate(n1, n2));
            else if (s.Equals("/"))
            {
                Tuple<int, int> datos = Division.operate(n1, n2);
                Console.WriteLine($"Resultado: {datos.Item1}");
                Console.WriteLine($"Resto: {datos.Item2}");
            }            
            else
                Console.WriteLine("Operador erróneo");
        
            }

    }
}
