using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_14
{
    class Program
    {
        /*9 0 7 0 0 3 2 1 0 0
             
        */
        static void Main(string[] args)
        {
            int n, nrZero = 0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            bool ok;
            int[] v = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == 0)
                    nrZero++;
            }
            if(nrZero>0)
            {
                for (int i = 0; i<n;i++)
                {
                    if(v[i]==0)
                    {
                        for(int j=i;j<n;j++)
                        {
                            int aux = v[i];
                            v[i] = v[j];
                            v[j] = aux;
                        }
                    }
                }
            }
            if(nrZero==0)
                Console.WriteLine("Nu exista elemente 0 in vector!");
            for(int i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
    }
}
