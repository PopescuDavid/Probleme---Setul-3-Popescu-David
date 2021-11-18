using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, minim = int.MaxValue, maxim = int.MinValue,pozMin=0,pozMax=0;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] < minim)
                {
                    minim = v[i];
                    pozMin = i;
                }
                if(v[i]>maxim)
                {
                    maxim = v[i];
                    pozMax = i;
                }
            }
            pozMin += 1;
            pozMax += 1;
            Console.WriteLine($"Cel mai mic element se afla pe pozitia {pozMin}, iar cel mai mare element se afla pe pozitia {pozMax}");
        }
    }
}
