using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_15
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
            for(int i=0;i<n-1;i++)
            {
               for(int j=i+1;j<n;j++)
                {
                    if(v[i]==v[j])
                    {
                        for (int k = j; k < n; k++)
                            v[k] = v[k + 1];
                        n--;
                        for (int q = i; q < n - 1; q++)
                            v[q] = v[q + 1];
                        n--;
                    }
                }
            }
            for(int i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
    }
}
