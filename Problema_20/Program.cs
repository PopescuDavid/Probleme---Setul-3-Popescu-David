using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nr = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            Console.WriteLine("Dati elementele vectorului v: ");
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(int i=0;i<n-1;i++)
            {
                if (v[i] == v[i + 1])
                {
                    nr++;    // Numarul de suprapuneri sa mareste de fiecare data cand 2 margele una langa alta is de aceeasi culoare / egale
                    int aux = v[i];
                    v[i] = v[i + 1];
                    v[i + 1] = aux;
                }
                    
            }
            for (int i = 0; i<n;i++)
                Console.Write(v[i]+" ");
            Console.WriteLine();
            Console.WriteLine($"Numarul de suprapuneri este {nr}");
        }
    }
}
