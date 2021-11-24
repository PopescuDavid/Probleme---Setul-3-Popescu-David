using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j, k = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] E = new int[n + 1];
            Console.WriteLine("Dati elementele vectorului E: ");
            for (i = 0; i < n; i++)
                E[i] = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            m = int.Parse(Console.ReadLine());
            int[] W = new int[m + 1];
            Console.WriteLine("Dati elementele vectorului W (sa fie de aceeasi dimensiune cu E) : ");
            for (i = 0; i < m; i++)
                W[i] = int.Parse(Console.ReadLine());
            for(i = 0; i < n - 1; i++)
            {
                for(j=i+1;j<n;j++)
                {
                    if(W[i]<W[j])
                    {
                        int aux = E[i];
                        E[i] = E[j];
                        E[j] = aux;
                    }
                }
            }

            Console.Write("Vectorul sortat bicriterial este: ");
            for(i=0;i<n;i++)
                Console.Write(E[i]+" ");
        }
    }
}
