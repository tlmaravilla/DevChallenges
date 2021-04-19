using System.Text;

namespace DevChallenges.Challenges
{
    public class MediumChallenges
    {
        public static string ReverseTheCase(string msg)
        {
            var bldr = new StringBuilder();
            foreach (var item in msg.ToCharArray())
            {
                if (char.IsWhiteSpace(item))
                {
                    bldr.Append(item);
                    continue;
                }

                // Use Ternary conditional operator
                var itemRevCase = char.IsUpper(item) ? item.ToString().ToLower() : item.ToString().ToUpper();
                bldr.Append(itemRevCase);
            }

            return bldr.ToString();
        }
    }
}