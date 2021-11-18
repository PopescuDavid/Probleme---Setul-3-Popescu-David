using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x,k;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            for(int i=0;i<k;i++)
            {
                x = v[0];
                for(int j = 0; j < n - 1; j++)
                       v[j] = v[j + 1];
                v[n - 1] = x;
            }
            for (int i = 0; i < n; i++)
                     Console.Write(v[i] + " ");
        }
    }
}
