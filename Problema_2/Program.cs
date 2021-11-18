using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k,poz=1,minim=int.MaxValue;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == k)
                {
                    poz = i;
                    if (poz < minim)
                        minim = poz;
                }
            }
            minim += 1;
            if(poz==1)
                Console.WriteLine(-1);
            else
                Console.WriteLine($"Prima pozitie pe care apare elementul {k} este {minim}");
        }
    }
}
