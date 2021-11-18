using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(int i=0;i<n/2;i++)
            {
                int aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;
            }
            for(int i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
    }
}
