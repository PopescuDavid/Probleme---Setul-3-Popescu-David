using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,contor=0,x=-1,ap=0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            Console.WriteLine("Dati elementele vectorului a: ");
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (contor == 0)
                {
                    contor++;
                    x = a[i];
                }
                else
                {
                    if (contor == x)
                        contor++;
                    else
                        contor--;
                }
            }
            contor = 0;
            for (i=0;i<n;i++)
                if (a[i] == x)
                    contor++;
            if(contor>n/2)
                Console.WriteLine($"Elementul majoritate este {x} care apare de {contor} ori");
            else
                Console.WriteLine("nu exista");
        }
    }
}
