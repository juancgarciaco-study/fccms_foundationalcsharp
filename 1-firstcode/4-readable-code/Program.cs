﻿using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Threading;

namespace readable_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //_3_exercise_comment_code();
            ReverseMessage();
        }

        /// <summary>
        /// The following code creates five random OrderIDs
        /// to test the fraud detection process.OrderIDs
        /// consist of a letter from A to E, and a three
        /// digit number.Ex.A123.
        /// </summary>
        static void _3_exercise_comment_code()
        {
            Random random = new Random();
            string[] orderIDs = new string[5];
            // Loop through each blank orderID
            for (int i = 0; i < orderIDs.Length; i++)
            {
                // Get a random value that equates to ASCII letters A through E
                int prefixValue = random.Next(65, 70);
                // Convert the random value into a char, then a string
                string prefix = Convert.ToChar(prefixValue).ToString();
                // Create a random number, pad with zeroes
                string suffix = random.Next(1, 1000).ToString("000");
                // Combine the prefix and suffix together, then assign to current OrderID
                orderIDs[i] = prefix + suffix;
            }
            // Print out each orderID
            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
        }

        /*
        This code reverses a message, counts the number of times 
        a particular character appears, then prints the results
        to the console window.
        */
        static void ReverseMessage()
        {
            string originalMessage = "The quick brown fox jumps over the lazy dog.";

            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }

            string newMessage = new String(message);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");
        }
    }
}
