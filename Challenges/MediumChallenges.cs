﻿using System.Linq;

namespace DevChallenges.Challenges
{
    public class MediumChallenges
    {
        public static string ReverseTheCase(string str) =>

            // First Try, lets stream line a bit with linq

            //var bldr = new StringBuilder();
            //foreach (var item in msg.ToCharArray())
            //{
            //    if (char.IsWhiteSpace(item))
            //    {
            //        bldr.Append(item);
            //        continue;
            //    }

            //    // Use Ternary conditional operator
            //    var itemRevCase = char.IsUpper(item) ? item.ToString().ToLower() : item.ToString().ToUpper();
            //    bldr.Append(itemRevCase);
            //}

            //return bldr.ToString();

            new string(str.ToCharArray().Select(
                s => char.IsLower(s) ? char.ToUpper(s) : char.ToLower(s)).ToArray());

        /*
         * Create a function that takes two numbers as arguments (num, length)
         * and returns an array of multiples of num until the array length reaches length
         *
         * Example
         * ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
         * ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
         * ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
         */

        public static int[] ArrayOfMultiples(int num, int len)
        {
            // forloop i
            // multiple number by itself len times, start at 1

            // my first try with list
            //var myList = new List<int>();
            //for (var i = 1; i <= len; i++)
            //    myList.Add(num*i);

            //return myList.ToArray();

            // do it now with array only
            var myArr = new int[len];
            for (int i = 0; i < len; i++)
            {
                myArr[i] = num * (i + 1);
            }

            return myArr;
        }
    }
}