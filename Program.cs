using System;
using System.Text;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
       
        
        public static void Main(String[] args)
        {
            VowelRemover vowelOut = new VowelRemover();
            Catalog removerNEsp = new Catalog();

            string option;
            Console.Write("Input a Text:");
            string text;
            text = Console.ReadLine();

            Console.WriteLine("Do you want to remove vowel write 1 if you want to remove 'n' and 'spaces' write 2:", vowelOut, removerNEsp);
            option = Console.ReadLine();
            var result= String.Empty;
            
            if (option == "1")
            {
               result= vowelOut.RemoveVowels(text);
            }
            if(option == "2")
            {
               result= vowelOut.RemoveNEsp(text);
            }


            Console.Write(result);
            Console.ReadKey();
        }
    }
}
