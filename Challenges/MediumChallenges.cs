using System;
using System.Linq;
using System.Text;

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
    }
}