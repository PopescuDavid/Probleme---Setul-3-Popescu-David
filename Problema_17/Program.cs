using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_17
{
    class Program
    {
        private static void Main(string[] args)
        {
            int numar, baza;
            bool ok = false;
            string verificareNumar;
            Console.Write("Dati numarul pe care doriti sa il convertiti: ");
            numar = int.Parse(Console.ReadLine());
            Console.Write("Dati baza in care doriti sa convertiti numarul:  ");
            baza = int.Parse(Console.ReadLine());
            verificareNumar = numar.ToString();
            if (numar > 9)
            {
                for (int i = 0; i < verificareNumar.Length - 1; i++)
                {
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '0')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("10", "A");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '1')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("11", "B");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '2')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("12", "C");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '3')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("13", "D");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '4')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("14", "E");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '5')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("15", "F");
                        break;
                    }
                }
            }

            if (ok == true)
            {
                if (baza >= 2 && baza <= 16)
                {
                    if (baza == 16)
                    {
                        Console.WriteLine($"Numarul introdus, modificat cu caracatere ASCII (A-F) inainte de convertirea sa este: {verificareNumar}");
                    }
                    ConvertFromBase10ToAnyBase(numar, baza);
                    
                }
                else
                    Console.WriteLine("Baza introdusa nu se afla in intervalul [2,16]. Incercati din nou!");
            }
            else
            {
                if (baza >= 2 && baza <= 16)
                {
                    Console.WriteLine($"Numarul {numar.ToString()} nu se poate reprezenta cu ajutorul caracterelor cuprinse intre A-F");
                    ConvertFromBase10ToAnyBase(numar, baza);
                }
                else
                    Console.WriteLine("Baza introdusa nu se afla in intervalul [2,16]. Incercati din nou!");
            }
        }

        private static void ConvertFromBase10ToAnyBase(int numar, int baza)
        {
            int rest, n, noulNumar = 0, p = 1;
            string verificareNumar;
            bool ok = false;
            n = numar;
            while (n > 0)
            {
                rest = n % baza;
                noulNumar = noulNumar + rest * p;
                p = p * 10;
                n = n / baza;
            }
            Console.WriteLine($"Numarul convertit din baza 10 in baza {baza} este: {noulNumar}");
            verificareNumar = noulNumar.ToString();
            if (numar > 9)
            {
                for (int i = 0; i < verificareNumar.Length - 1; i++)
                {
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '0')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("10", "A");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '1')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("11", "B");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '2')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("12", "C");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '3')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("13", "D");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '4')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("14", "E");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '5')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("15", "F");
                        break;
                    }
                }
            }
            if (ok == true && baza == 16)
                Console.WriteLine($"Noul numar convertit cu caracatere ASCII (A-F) este: {verificareNumar}");
        }
    }
}
