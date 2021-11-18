﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_12
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
            int aux1, aux2;
            for(int i=0;i<n-1;i++)
            {
                aux2 = i;
                for(int j=i+1;j<n;j++)
                {
                    if (v[j] < v[aux2])
                        aux2 = j;
                }
                aux1 = v[aux2];
                v[aux2] = v[i];
                v[i] = aux1;
            }
            Console.WriteLine("Sirul sortat este: ");
            for(int i=0;i<n;i++)
                Console.Write(v[i]+" ");
        }
    }
}
