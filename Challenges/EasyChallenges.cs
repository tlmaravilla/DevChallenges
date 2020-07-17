using System;
using System.Collections.Generic;
using System.Text;

namespace DevChallenges.Challenges
{
    public class EasyChallenges
    {
        /*
       Create a function that takes a word and returns true if the word has two consecutive identical letters.

       Examples
           DoubleLetters("loop") ➞ true
           DoubleLetters("yummy") ➞ true
           DoubleLetters("orange") ➞ false
           DoubleLetters("munchkin") ➞ false
       */
        public static bool DoubleLetters(string msg)
        {
            char lastChar = ' ';
            foreach (var c in msg.ToCharArray())
            {
                if (c == lastChar)
                    return true;
                lastChar = c;
            }

            return false;
        }

        /*
        Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
  
        Examples
          HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
          HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
          HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
        */
        public static string HackerSpeak(string msg)
            => msg.ToLower().Replace("a", "4")
                .Replace("e", "3")
                .Replace("i", "1")
                .Replace("o", "0")
                .Replace("s", "5");

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
    }
}