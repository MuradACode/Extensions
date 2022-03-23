using Extensions.Extensions;
using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "extensions";
            string capitalizedText = text.Capitalize();
            string revercedText = text.Reverse();
            string letter = text.GetLetter(2);
            string[] stringArr = { "Extensions", "Capitalize", "Reverse" };
            string[] addedStringArr = stringArr.Add(1, text);
            char[] charArr = { 'e', 'x', 't', 'e', 'n', 't', 'i', 'o', 'n', 's' };
            char[] addedCharArr = charArr.Add(1, 's');
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] addedIntArr = intArr.Add(2, 4);
            Console.WriteLine("Before: " + text + "\nCapitalized: " + capitalizedText + "\nReverced: " + revercedText + "\nLetter: " + letter + "\nString array: ");
            foreach (var item in stringArr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nAdded string array: ");
            foreach (var item in addedStringArr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nChar array: ");
            foreach (var item in charArr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nAdded char array: ");
            foreach (var item in addedCharArr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nInt array: ");
            foreach (var item in intArr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nAdded int array: ");
            foreach (var item in addedIntArr)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
