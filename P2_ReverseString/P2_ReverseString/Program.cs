using System;

namespace P2_ReverseString // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String word;
            String reverseWord;
            
            Console.WriteLine("Let's play! Enter a word and we will reverse it for you. ");
            word = Console.ReadLine();

            Console.WriteLine($"You wrote {word[1]}");
        }
    }
}