using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k,e;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n+1];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            k--;
            if(k>=0 && k<n)
            {
                 Console.Write("e= ");
                 e = int.Parse(Console.ReadLine());
                 for (int i = n - 1; i >= k; i--)
                        v[i + 1] = v[i];
                 v[k] = e;
                for(int i=0;i<=n;i++)
                Console.Write("{0}",v[i]+" ");
            }
            else
                Console.WriteLine("Pozitia nu exista");
        }
    }
}
