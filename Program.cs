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

            Console.WriteLine("For remove the vowels write '1', and for remove the 'n/N' and spaces write '2'");
            string option;
            option = Console.ReadLine();

            var result = string.Empty;
            RemoveCharacter removeCharacter = new RemoveCharacter();
            ICatalog vowelsCatalog = new VowelsCatalog();
            ICatalog specialCatalog = new SpecialCatalog();
            
            if (option == "1")
            {
                result = removeCharacter.CharacterRemove(vowelsCatalog.GetCatalog(), text);
            }
            if(option == "2")
            {
                result = removeCharacter.CharacterRemove(specialCatalog.GetCatalog(), text);
            }

            Console.Write(result);
            Console.ReadKey();
        }
    }
}
