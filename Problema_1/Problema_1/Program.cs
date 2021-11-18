using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0 ;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                suma += v[i];
            }
            Console.WriteLine($"Suma elementelor din vector este {suma}");
        }
    }
}
