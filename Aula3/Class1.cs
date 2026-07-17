using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp1.Aula3
{
    internal class conversor
    {
        public static void Main()
        {
            int numero1 = 10;
            if (numero1 > 0) { numero1 = 10; Console.WriteLine("O número é positivo"); }
            else if (numero1 < 0) { Console.WriteLine("O número é negativo"); }
            else { Console.WriteLine("O número é zero"); }

            Console.WriteLine("numero2");
            int numero2 = 20;
            Console.WriteLine("numero3");
            int numero3 = 30;

            int maior = numero2;
            if (numero2 > maior)
            {
                maior = numero2;
            }
            if (numero3 > maior)
            {
                maior = numero3;
            }

            Console.WriteLine("o maior numero é:" + maior);

            Console.Write("digite sua nota");
            double nota =
            double.Parse(Console.ReadLine());
            if (nota >= 7)
                Console.WriteLine("aprovado");
            else Console.WriteLine("reprovado");





           
            
            
            
            
            
            
            Console.ReadKey();

        }
    }
}