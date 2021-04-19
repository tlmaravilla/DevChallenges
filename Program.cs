using DevChallenges.Challenges;
using DevChallenges.Sandbox;
using System;

namespace DevChallenges
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Dev Challenge in 3 2 1, GO!");

            //Easy();

            Medium();

            //CSharp8Playground();

            Console.ReadLine();
        }

        static void Medium()
        {
            Console.WriteLine("Starting Medium Challenges in 3 2 1, GO!");

            var caseRev = MediumChallenges.ReverseTheCase("Happy Birthday");


            Console.ReadLine();
        }


        static void Easy()
        {
            Console.WriteLine("Starting EASY Challenges in 3 2 1, GO!");

            //var isSameCase = EasyChallenges.CheckIfSameCase("HeLLO");
            //Console.WriteLine($"Answer: {isSameCase}");

            //var hackerResult = EasyChallenges.HackerSpeak("javascript is cool");
            //Console.WriteLine($"Answer: {hackerResult}");

            //hackerResult = EasyChallenges.HackerSpeak("programming is fun");
            //Console.WriteLine($"Answer: {hackerResult}");

            //var hasDoubleLetters = EasyChallenges.DoubleLetters("javascript is cool");
            //Console.WriteLine($"Answer: {hasDoubleLetters}");

            //var evenArray = EasyChallenges.EliminateOddNbrsInArray(new[]{1, 2, 3, 4, 5, 6, 7, 8});
            //Console.WriteLine($"Answer: {string.Join(",", evenArray)}");

            //evenArray = EasyChallenges.EliminateOddNbrsInArray(new[] { 43, 65, 23, 89, 53, 9, 6 });
            //Console.WriteLine($"Answer: {string.Join(",", evenArray)}");

            //evenArray = EasyChallenges.EliminateOddNbrsInArray(new[] { 718, 991, 449, 644, 380, 440 });
            //Console.WriteLine($"Answer: {string.Join(",", evenArray)}");

            var firstLastCharRemoved = EasyChallenges.RemoveStringFirstLastChar("Happy");


            
            Console.ReadLine();
        }

        private static void CSharp8Playground()
        {
            Console.WriteLine("C# 8 Practice in 3 2 1, GO!");

            CSharp8.MyIndicesRanges();
            CSharp8.MyNullCoalescingAssignment();

            CSharp8.ConnectionUsingTuple(("endpointUrl", "apiKey"), "resource");
        }
    }
}