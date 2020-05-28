using System;
using System.Linq;

namespace DevChallenges
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Dev Challenge in 3 2 1, GO!");

         var result = CheckIfSameCase("HeLLO");
         System.Console.WriteLine($"CheckSameCase: {result}");

      }


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
