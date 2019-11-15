using System;
using System.Text;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {

        
        public static void Main(String[] args)
        {
            Console.WriteLine("Input a text:");
            String text;
            text = Console.ReadLine();
            VowelOut vowel = new VowelOut();
            Console.Write(vowel.IsThereVowels(text));
            Console.ReadKey();
        }
    }
}
