using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m,nr=0;
            bool ok=false;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            Console.WriteLine("Dati elementele vectorului v: ");
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            m = int.Parse(Console.ReadLine());
            int[] u = new int[m + 1];
            Console.WriteLine("Dati elementele vectorului u: ");
            for (int i = 0; i < m; i++)
                u[i] = int.Parse(Console.ReadLine());
            if(n>m)
            {
                for(int i=0;i<n;i++)
                {
                    for(int j=0;j<m;j++)
                    {
                        if (v[i] == v[j])
                        {
                            ok = true;
                            i++;
                        }
                        else
                            ok = false;
                    }
                    if (ok == true)
                    {
                        nr++;
                        i--;
                    }
                }
            }
            Console.WriteLine($"Vectorul u apare in v de {nr} ori");
        }
    }
}
