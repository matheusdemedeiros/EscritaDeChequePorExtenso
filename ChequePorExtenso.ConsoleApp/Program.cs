using ChequePorExtenso.Dominio;
using System;
using System.Collections.Generic;

namespace ChequePorExtenso.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorReais cr = new ConversorReais();
            List<string> numerosExtenso = new List<string>();
            for (long i = 1; i < 999999999999; i++)
            {
                numerosExtenso.Add($"{i} : {cr.ConverterReais(i)}");
                Console.WriteLine($"{i} : {cr.ConverterReais(i)}");

            }

            //numerosExtenso.ForEach(x => Console.WriteLine(x));


        


            Console.ReadLine();
        }
    }
}
