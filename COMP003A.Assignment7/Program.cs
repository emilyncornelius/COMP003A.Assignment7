/*
 * Author: Emily Cornelius
 * Course: Comp 003A
 * Purpose: Coding Assignment for Data Structures
 * 
 */

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Xml;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SectionInput = "Array - CharacterCounter ";
            SectionSeparator(SectionInput);

            Console.WriteLine("Please enter a letter");
            string letter = Console.ReadLine();

            Console.WriteLine("Please enter a word");
            string Mississippi = Console.ReadLine();

            if (letter.Length == 1)
            {
                char singleletter = letter[0];
                CharacterCounter(singleletter, Mississippi);
            }

            string SectionInput2 = "Array - IsPalindrome ";
            SectionSeparator(SectionInput2);

            Console.WriteLine("\nPlease enter a word to check if it is a palindrome");
            string Racecar = Console.ReadLine();
            IsPalindrome(Racecar);
            if (IsPalindrome(Racecar))
            {
                Console.WriteLine($"Is the word {Racecar} palindrome: True");
            } else
            {
                Console.WriteLine($"Is the word {Racecar} palindrome: False");
            }
            string sectionInput3 = "List - Add ";
            SectionSeparator(sectionInput3);

            List<string> names = new List<string>();
            char userInput = default;

            do
            {
                Console.WriteLine("\nPlease enter a name");
                string name1 = Console.ReadLine();
                names.Add(name1);

                Console.WriteLine("Press any key to add more or (e) to exit.");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine("");

            } while (userInput != 'e');
           

            string sectionInput4 = "List - Traversal ";
            SectionSeparator(sectionInput4);

            TraverseList(names);

            string sectionInput5 = "List - Reverse Traversal ";
            SectionSeparator(sectionInput5);

            TraverseListReverse(names);
        }
        static void SectionSeparator(string input)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("           " + input + "Section");
            Console.WriteLine("**************************************************");
        }
        public static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            foreach (char s in word)
            {
                if (char.ToLower(s) == char.ToLower(characterInput))
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} letter {characterInput} in the word {word}");
            return count;
        }
        public static bool IsPalindrome(string word)
        {
            string reversedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                reversedWord += char.ToLower(word[i]);
            }

            return string.Equals(word.ToLower(), reversedWord);
        }
        public static void TraverseList(List<string> list)
        {
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
        }
        public static void TraverseListReverse(List<string> list)
        {
            list.Reverse();
            foreach (string name in list)
            {
                Console.WriteLine(name);
             }
        }
     }
}

