using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, minim = int.MaxValue, maxim = int.MinValue,nrMax=0,nrMin=0;
            bool ok = true;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] >= maxim)
                {
                    if (maxim != v[i])
                        nrMax = 0;
                    maxim = v[i];
                    nrMax++;
                }
                if(v[i]<=minim)
                {
                    if (minim != v[i])
                        nrMin = 0;
                    minim = v[i];
                    nrMin++;
                }
            }
            Console.WriteLine($"Cea mai mare valoare este {maxim} care apare de {nrMax} ori, iar cea mai mica valoare este {minim} care apare de {nrMin} ori");
        }

    }
}
