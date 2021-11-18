using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,x;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            x = v[0];
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];
            v[n-1] = x;
            for(int i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
    }
}
