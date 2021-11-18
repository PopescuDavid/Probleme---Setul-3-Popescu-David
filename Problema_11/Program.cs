using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=1;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            while(i<=n)
            {
                if(prime(i))
                    Console.Write(i+" ");
                i++;
            }
        }

        static bool prime(int n)
        {
            if (n < 2)
                return false;
            if (n % 2 == 0)
                return false;
            if (n == 2)
                return true;
            for (int d = 3; d * d <= n; d += 2)
                if (n % d == 0)
                    return false;
            return true;
        }
    }
}
