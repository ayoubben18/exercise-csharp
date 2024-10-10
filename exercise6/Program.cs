using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    internal class Program
    {

        static string InverserUneLoop(string input)
        {
            char[] reversedArray = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversedArray[i] = i == 0 ? char.ToUpper(input[input.Length - 1 - i]) : char.ToLower(input[input.Length - 1 - i]);
            }
            return new string(reversedArray);
        }

        static string InverserDeuxIndices(string input)
        {
            char[] charArray = input.ToCharArray();
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = (left == 0) ? char.ToUpper(charArray[right]) : char.ToLower(charArray[right]);
                charArray[right] = char.ToLower(temp);

                left++;
                right--;
            }

            return new string(charArray);
        }
        static void Main(string[] args)
        {
            string original = "Mon nom";

            string reversedSingleLoop = InverserUneLoop(original);
            string reversedTwoIndices = InverserDeuxIndices(original);

            Console.WriteLine("Original: " + original);
            Console.WriteLine("Reversed (Single Loop): " + reversedSingleLoop);
            Console.WriteLine("Reversed (Two Indices): " + reversedTwoIndices);
        }
    }
}
