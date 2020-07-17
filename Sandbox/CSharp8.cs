using System;
using System.Collections.Generic;
using System.Text;

namespace DevChallenges.Sandbox
{
    public class CSharp8
    {
        /// <summary>
        /// System.Index represents an index into a sequence
        /// use ^
        /// </summary>
        public static void MyIndicesRanges()
        {
            var words = new string[]
            {
                // index from start    index from end
                "The", // 0                   ^9
                "quick", // 1                   ^8
                "brown", // 2                   ^7
                "fox", // 3                   ^6
                "jumped", // 4                   ^5
                "over", // 5                   ^4
                "the", // 6                   ^3
                "lazy", // 7                   ^2
                "dog" // 8                   ^1
            }; // 9 (or words.Length) ^0

            // Get last word
            Console.WriteLine($"The last word is {words[^1]}");

            // NOTE:
            // A range specifies the start and end of a range. The start of the range is inclusive, but the end of the range is exclusive, meaning the start is included in the range but the end isn't included in the range. 

            // So to get words 1-3 you must include 4
            // Get words[1] - words[3]
            var quickBrownFox = words[1..4]; // creates a string array
            Console.WriteLine($"{string.Join(",", quickBrownFox)}");

            var lazyDog = words[^2..^0]; // Get send to last and last word, but not end
            Console.WriteLine($"{string.Join(",", lazyDog)}");

            // Range examples
            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
        }

        public static void MyNullCoalescingAssignment()
        {
            //use the ??= operator to assign the value of its right-hand operand to its left-hand operand only if the left-hand operand evaluates to null

            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers)); // output: 17 17
            Console.WriteLine(i); // output: 17

            //NOTE: The null - coalescing operator ?? returns the value of its left - hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result. The ?? operator doesn't evaluate its right-hand operand if the left - hand operand evaluates to non-null.
        }

        // Tuple as input parm example
        public static void ConnectionUsingTuple((string EndpointUrl, string ApiKey) details, string resource)
        {
            // validate inputs
            // create connection to endpoint
            ConnectToApi(details.EndpointUrl, details.ApiKey);
            // save the resource


            // New to c# 8 - static local class
            static void ConnectToApi(string endpointUrl, string apiKey)
            {
                // do the connection
            }

            static void ConnectionUsingParmObject(StorageServiceDetails details, string resource)
            {
                // build http request using endpoint and api to connect
                // send msg with resource
            }
        }
    }

}