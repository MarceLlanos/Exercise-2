using System;
using System.Text;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
       
        
        public static void Main(String[] args)
        {
            Console.Write("Input a Text:");
            string text;
            text = Console.ReadLine();

            Console.WriteLine("For remove the vowels write '1', for remove de 'n/N' and spaces write '2' ");
            string option;
            option = Console.ReadLine();

            var result= String.Empty;
            CharacterRemover characterRemover = new CharacterRemover();
            ICatalog vowelsCatalog = new VowelsCatalog();
            ICatalog specialCatalog = new SpecialCatalog();
            
            if (option == "1")
            {
               result = characterRemover.RemoveCharacter(vowelsCatalog.GetCatalog(), text);
            }
            if(option == "2")
            {
                result = characterRemover.RemoveCharacter(specialCatalog.GetCatalog(), text);
            }

            Console.Write(result);
            Console.ReadKey();
        }
    }
}
