using ChequePorExtenso.Dominio;
using System;
using System.Collections.Generic;

namespace ChequePorExtenso.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cr = new ConversorReais();
            var numerosExtenso = new List<string>();
            long maxNumber = 1000;

            if (args.Length > 0 && long.TryParse(args[0], out long argNumber))
            {
                maxNumber = argNumber;
            }

            Console.WriteLine($"Humanizando os números de 1 a {maxNumber} !!");

            for (long i = 1; i <= maxNumber; i++)
            {
                numerosExtenso.Add($"{i} : {cr.ConverterReais(i)}");
                Console.WriteLine($"{i} : {cr.ConverterReais(i)}");
            }

            Console.ReadKey();
        }
    }
}
