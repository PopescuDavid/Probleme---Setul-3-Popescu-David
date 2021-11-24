using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            Console.WriteLine("Dati elementele vectorului a: ");
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            MergeSort(a, 0, a.Length - 1);
            Console.Write("Vectorul sortat este: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
        }
        static void Merge(int[] v, int st, int mij, int dr)
        {
            int[] a = new int[mij - st + 1];
            int[] b = new int[dr - mij];
            Array.Copy(v, st, a, 0, mij - st + 1);
            Array.Copy(v, mij + 1, b, 0, dr - mij);
            int i = 0;
            int j = 0;
            for (int k = st; k < dr + 1; k++)
            {
                if (i == a.Length)
                {
                    v[k] = b[j];
                    j++;
                }
                else if (j == b.Length)
                {
                    v[k] = a[i];
                    i++;
                }
                else if (a[i] <= b[j])
                {
                    v[k] = a[i];
                    i++;
                }
                else
                {
                    v[k] = b[j];
                    j++;
                }
            }
        }
        static void MergeSort(int[] v, int st, int dr)
        {
            if (st < dr)
            {
                int mij = (st + dr) / 2;
                MergeSort(v, st, mij);
                MergeSort(v, mij + 1, dr);
                Merge(v, st, mij, dr);
            }
        }
    }
}
