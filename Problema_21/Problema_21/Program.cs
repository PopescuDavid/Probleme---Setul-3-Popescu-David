using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, k=0,i,j;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n + 1];
            Console.WriteLine("Dati elementele vectorului v (sa fie in ordine crescatoare sau descrescatoare!): ");
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            m = int.Parse(Console.ReadLine());
            int[] u = new int[m + 1];
            Console.WriteLine("Dati elementele vectorului u (sa fie in ordine crescatoare sau descrescatoare!): ");
            for (j = 0; j < m; j++)
                u[j] = int.Parse(Console.ReadLine());
            int[] a = new int[m+n];
            i = 0; j = 0;
            while (i < n && j < m)
            {
                if (v[i] < u[j])
                {
                    a[k++] = v[i++];
                }
                else
                {
                    a[k++] = u[j++];
                }
            }
            if(i<=n)
            {
                for(int p=i;p<n;p++)
                {
                    a[k++] = v[p];
                }
            }
            if (j <= m)
            {
                for(int p=j;p<m;p++)
                {
                    a[k++] = u[p];
                }
            }
            for(int p=0;p<k;p++)
                Console.Write(a[p]+" ");
        }
    }
}
