using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti cele doua numere: ");
            string str1;
            str1 = Console.ReadLine();
            string str2;
            str2 = Console.ReadLine();
            Console.Write("Suma celor doua numere este: ");
            Console.WriteLine(findSum(str1,str2));
            Console.Write("Diferenta dintre cele doua numere este: ");
            Console.WriteLine(findDiff(str1,str2));
        }
        static string findSum(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }
            string str = "";
            int n1 = str1.Length, n2 = str2.Length;
            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);
            str1 = new string(ch);
            char[] ch1 = str2.ToCharArray();
            Array.Reverse(ch1);
            str2 = new string(ch1);
            int carry = 0;
            for (int i = 0; i < n1; i++)
            {
                int sum = ((int)(str1[i] - '0') +
                        (int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            for (int i = n1; i < n2; i++)
            {
                int sum = ((int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            if (carry > 0)
                str += (char)(carry + '0');
            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);
            return str;
        }
        static bool isSmaller(string str1, string str2)
        {
            int n1 = str1.Length, n2 = str2.Length;
            if (n1 < n2)
                return true;
            if (n2 < n1)
                return false;
            for (int i = 0; i < n1; i++)
                if (str1[i] < str2[i])
                    return true;
                else if (str1[i] > str2[i])
                    return false;
            return false;
        }

        static string findDiff(string str1, string str2)
        {
            if (isSmaller(str1, str2))
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }
            string str = "";
            int n1 = str1.Length, n2 = str2.Length;
            char[] ch1 = str1.ToCharArray();
            Array.Reverse(ch1);
            str1 = new string(ch1);
            char[] ch2 = str2.ToCharArray();
            Array.Reverse(ch2);
            str2 = new string(ch2);
            int carry = 0;
            for (int i = 0; i < n2; i++)
            {
                int sub = ((int)(str1[i] - '0')- (int)(str2[i] - '0') - carry);
                if (sub < 0)
                {
                    sub = sub + 10;
                    carry = 1;
                }
                else
                    carry = 0;

                str += (char)(sub + '0');
            }
            for (int i = n2; i < n1; i++)
            {
                int sub = ((int)(str1[i] - '0') - carry);
                if (sub < 0)
                {
                    sub = sub + 10;
                    carry = 1;
                }
                else
                    carry = 0;
                str += (char)(sub + '0');
            }
            char[] ch3 = str.ToCharArray();
            Array.Reverse(ch3);
            return new string(ch3);
        }
    }
}
