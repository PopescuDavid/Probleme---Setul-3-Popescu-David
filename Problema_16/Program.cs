using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_16
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
            int cmmdc = v[0];
            for(int i=1;i<n;i++)
            {
                int aux = v[i];
                while(aux!=cmmdc)
                {
                    if (aux > cmmdc)
                        aux = aux - cmmdc;
                    else if (aux < cmmdc)
                        cmmdc = cmmdc - aux;
                }
            }
            Console.WriteLine($"Cel mai mare divizor al elementelor din vector este {cmmdc}");
        }
    }
}
