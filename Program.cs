using System;
using System.Text.RegularExpressions;

namespace Stage1Test
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Digite una cadena a limpiar:");
            Console.WriteLine("Cadena limpia: " + AvoidSpecialCharacters(Console.ReadLine()));
        }


        static string AvoidSpecialCharacters(string text)
        {
            string replacedText= Regex.Replace(text, @"[^\w\-\s]", "");
            return replacedText == String.Empty ? "NA":replacedText;
        }
    }
}