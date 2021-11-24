using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m,i,j,k=0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n + 1];
            Console.WriteLine("Dati elementele vectorului a: ");
            for (i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            m = int.Parse(Console.ReadLine());
            int[] b = new int[m + 1];
            Console.WriteLine("Dati elementele vectorului b: ");
            for (i = 0; i < m; i++)
                b[i] = int.Parse(Console.ReadLine());
            int[] c = new int[n + m+2];
            i = 0; j = 0;
            while(i<n && j<m)
            {
                if(a[i]<b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }
            if (i <= n)
            {
                for(int p=i;i<n;p++)
                    c[k++] = a[p];
            }
            if (j <= m)
            {
                for (int p = j; p < m; p++)
                    c[k++] = b[p];
            }
            for(int p=0;p<k;p++)
                Console.Write(c[p]+" ");
        }
    }
}
