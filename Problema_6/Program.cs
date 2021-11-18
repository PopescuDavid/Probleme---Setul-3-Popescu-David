using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            k--;
            if(k>=0 && k<n)
            {
                for (int i = k; i < n - 1; i++)
                    v[i] = v[i + 1];
                n--;
                for(int i=0;i<n;i++)
                    Console.Write(v[i]+" ");
            }
        }
    }
}
