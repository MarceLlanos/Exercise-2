using System;
using System.Text;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
       
        
        public static void Main(String[] args)
        {
            VowelOut vowelOut = new VowelOut();
            IIsInCatalog isInCatalog = vowelOut;
            Console.WriteLine("Input a text:");
            String text;
            text = Console.ReadLine();
            
            Console.Write(vowelOut.IsThereVowels(text));
            Console.ReadKey();
        }
    }
}
