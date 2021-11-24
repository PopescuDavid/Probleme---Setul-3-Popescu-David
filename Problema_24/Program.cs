using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            Console.Write("m= ");
            m = int.Parse(Console.ReadLine());
            int[] b = new int[m + 1];
            Console.WriteLine("Dati elementele vectorului a: ");
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului b: ");
            for (int i = 0; i < m; i++)
                b[i] = int.Parse(Console.ReadLine());
            Console.Write("Elementele intersectie sunt: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i] == b[j])
                    {
                        a[i] = 1;
                        Console.Write(1+" ");
                    }
                    else
                    {
                        a[i] = 0;
                        Console.Write(0+" ");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Elementele reuniunii sunt: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            for (int j = 0; j < m; j++)
                Console.Write(b[j] + " ");
            Console.WriteLine();
        }
    }
}