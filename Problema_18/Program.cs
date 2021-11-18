using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x,a;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("x= ");
            x = int.Parse(Console.ReadLine());
            int[] v= new int[n + 1];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            a = 0;
            for (int i = n - 1; i >= 0; i--)
                a = a * x + v[i];
            Console.WriteLine($"Valoarea polinomului este a={a}");
        }
    }
}
