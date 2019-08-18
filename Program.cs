using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Anagram Checker");
            
            Console.WriteLine("Do you want to enter your word and probable Anagrams? (Yes/No)");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                Add();
            }
            else if (answer == "No")
            {
                Console.WriteLine("GoodBye");
            }
            else 
            {
                Console.WriteLine("Invalid Option");
            }
        
        }

        static void Add()
        {
            Console.WriteLine("Enter your Word:");
            string inputWord = Console.ReadLine();

            Console.WriteLine("Enter first probable anagram:");
            string string1 = Console.ReadLine();

            Console.WriteLine("Enter second probable anagram:");
            string string2 = Console.ReadLine();

            Console.WriteLine("Enter third probable anagram:");
            string string3 = Console.ReadLine();

            List<string> probableAnagrams = new List<string> {};
            
            probableAnagrams.Add(string1);
            probableAnagrams.Add(string2);
            probableAnagrams.Add(string3);

            string[] anagrams = probableAnagrams.ToArray();
            string majorWord = inputWord;
            string word1 = anagrams[0];
            string word2 = anagrams[1];
            string word3 = anagrams[2];
            
            char[] mainWord = majorWord.ToCharArray();
            char[] text1 = word1.ToCharArray();
            char[] text2 = word2.ToCharArray();
            char[] text3 = word3.ToCharArray();

            Array.Sort(mainWord);
            Array.Sort(text1);
            Array.Sort(text2);
            Array.Sort(text3);

            string sortedWord = string.Join("", mainWord);
            string sortedString1 = string.Join("", text1);
            string sortedString2 = string.Join("", text2);
            string sortedString3 = string.Join("", text3);

            if (sortedWord == sortedString1)
            {
                Console.WriteLine("Yes! " +string1 +" and " +inputWord+" are anagrams");
            }
            else
            {
                Console.WriteLine("No! " +string1 +" and " +inputWord+" are not anagrams");
            }
            
            if (sortedWord == sortedString2)
            {
                Console.WriteLine("Yes!" +string2 +" and " +inputWord+" are anagrams");
            }
            else 
            {
                Console.WriteLine("No! " +string2 +" and " +inputWord+" are not anagrams");
            }

            if (sortedWord == sortedString3)
            {
                Console.WriteLine("Yes! " +string3 +" and " +inputWord+" are anagrams");
            }
            else
            {
                Console.WriteLine("No! " +string3 +" and " +inputWord+" are not anagrams"); 
            }

            Main();
        }
    }    
}
