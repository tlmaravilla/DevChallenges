using System;
using System.Linq;

namespace DevChallenges
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Dev Challenge in 3 2 1, GO!");

         //  var result = CheckIfSameCase("HeLLO");

         var result = HackerSpeak("javascript is cool");
         System.Console.WriteLine($"Answer: {result}");
         result = HackerSpeak("programming is fun");
         System.Console.WriteLine($"Answer: {result}");
      }


      /*
      Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.

      Examples
        HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
        HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
        HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
      */
      public static string HackerSpeak(string msg)
            => msg.ToLower().Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");

      /*
      Create a function that returns true if an input string contains only uppercase or only lowercase letters.
      Examples
        SameCase("hello") ➞ true
        SameCase("HELLO") ➞ true
        SameCase("Hello") ➞ false
        SameCase("ketcHUp") ➞ false
      */
      public static bool CheckIfSameCase(string msg)
            => msg == msg.ToUpper() || msg == msg.ToLower();
      // The code below was my first attempt
      //   {
      //      if (msg.Equals(msg.ToUpper()))
      //         return true;

      //      if (msg.Equals(msg.ToLower()))
      //         return true;

      //      return false;
      //   }
   }
}
