using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i,poz=0,rez=0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            Console.WriteLine("Dati elementele vectorului a: ");
            for (i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati pozitia index: ");
            poz = int.Parse(Console.ReadLine());
            for(i=0;i<n-1;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(a[i]>a[j])
                    {
                        int aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
               if(i==poz)
                {
                    rez = a[i];
                    break;
                }
            }
            Console.WriteLine("Vectorul sortat este: ");
            for (i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            Console.WriteLine($"Elementul de pe pozitia {poz} este {rez}");
        }
    }
}
