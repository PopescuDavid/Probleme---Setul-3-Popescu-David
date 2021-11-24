using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n+1];
            Console.WriteLine("Dati elementele vectorului a: ");
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            QuickSort(a, 0, a.Length - 1);
            Console.Write("Vectorul sortat este: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]+" ");
        }
        static void QuickSort(int[] a, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Solve(a, start, end);
                QuickSort(a, start, i - 1);
                QuickSort(a, i + 1, end);
            }
        }

        static int Solve(int[]a, int start, int end)
        {
            int temp;
            int p = a[end];
            int i = start - 1;
            for (int j = start; j <= end - 1; j++)
            {
                if (a[j] <= p)
                {
                    i++;
                    temp =a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            temp = a[i + 1];
            a[i + 1] = a[end];
            a[end] = temp;
            return i + 1;
        }
    }
}
