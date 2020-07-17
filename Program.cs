using System;
using System.Linq;
using DevChallenges.Challenges;

namespace DevChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dev Challenge in 3 2 1, GO!");


            Easy();
           

            //Console.WriteLine("C# 8 Practice in 3 2 1, GO!");

            //MyIndicesRanges();
            //MyNullCoalescingAssignment();

            Console.ReadLine();
        }

        static void Easy()
        {
            Console.WriteLine("Starting EASY Challenges in 3 2 1, GO!");

            var isSameCase = EasyChallenges.CheckIfSameCase("HeLLO");
            Console.WriteLine($"Answer: {isSameCase}");

            var hackerResult = EasyChallenges.HackerSpeak("javascript is cool");
            Console.WriteLine($"Answer: {hackerResult}");

            hackerResult = EasyChallenges.HackerSpeak("programming is fun");
            Console.WriteLine($"Answer: {hackerResult}");

            var hasDoubleLetters = EasyChallenges.DoubleLetters("javascript is cool");
            Console.WriteLine($"Answer: {hasDoubleLetters}");
        }
    }
}