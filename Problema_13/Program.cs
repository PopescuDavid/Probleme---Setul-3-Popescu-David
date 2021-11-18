using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_13
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
                for(int j=i+1;j>0;j--)
                {
                    if(v[j-1]>v[j])
                    {
                        int aux = v[j - 1];
                        v[j - 1] = v[j];
                        v[j] = aux;
                    }
                }
            }
            for(int i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }

        
    }
}
