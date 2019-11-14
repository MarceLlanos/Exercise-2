using System;
using System.Text;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        public static bool IsVowel(string character)
        {
            bool aVowel;
            List<String> vowels = new List<string>();
            vowels.Add("a");
            vowels.Add("e");
            vowels.Add("i");
            vowels.Add("o");
            vowels.Add("u");
            vowels.Add("A");
            vowels.Add("E");
            vowels.Add("I");
            vowels.Add("O");
            vowels.Add("U");
            aVowel = false;
            foreach(string vowel in vowels)
            {
                if(vowel == character)
                {
                    aVowel = true;
                }
            }

            return aVowel;

        }
        public static bool IsVowel1(string character)
        {
            bool aVowel;
            aVowel = false;
            switch (character)
            {
                case "a": aVowel = true; break;
                case "e": aVowel = true; break;
                case "i": aVowel = true; break;
                case "o": aVowel = true; break;
                case "u": aVowel = true; break;
                case "A": aVowel = true; break;
                case "E": aVowel = true; break;
                case "I": aVowel = true; break;
                case "O": aVowel = true; break;
                case "U": aVowel = true; break;
            }
            return aVowel;
        }
        static void Main(string[] args)
        {   
            Console.WriteLine("Input a text:");
            String text;
            text = Console.ReadLine();
            StringBuilder builder = new StringBuilder(text);

            int length = text.Length - 1;

            foreach (char character in text)
            {
                if (IsVowel(character.ToString()) == true)
                {
                    builder.Replace(character.ToString(), "");
                }
            }
            Console.Write(builder);
            Console.ReadKey();
        }
    }
}
