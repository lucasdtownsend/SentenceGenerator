using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace townsendFunnySentenceGenerator
{
    class Program
    {
        static void Main()
        {
            // Initialize and define the string arrays for each part of the sentence.
            string[] nouns = { "She", "He", "It", "The cat", "The mongoose", "The trampoline", "The orange", "Musicians", "Programmers", "The shake" };
            string[] verbs = { "ate", "barbequed", "chirped", "collided", "sang", "spoke", "cartwheeled", "dined", "watched", "directed" };
            string[] preps = { "with the monkeys", "on the porch", "under the moon", "after the storm", "before the prince", "over the lake", "in the gazebo", "between the lines", "during the festival", "with them all" };

            // Create the random number object to be referenced for all three numbers.
            Random rnd = new Random();

            // Create the random numbers within specified value ranges for each part of the sentence.
            // Ranges are currently between 0 and 9, but three random numbers are needed, and their ranges can be easily changed with future updates.
            int nounRand = rnd.Next(10);
            int verbRand = rnd.Next(10);
            int prepRand = rnd.Next(10);

            // Initialize and define a StringBuilder object to build the sentence.
            StringBuilder sentence = new StringBuilder();

            // Use StringBuilder Append statements to construct the sentence with spaces between each part and a period at the end.
            sentence.Append(nouns[nounRand]);
            sentence.Append(" ");
            sentence.Append(verbs[verbRand]);
            sentence.Append(" ");
            sentence.Append(preps[prepRand]);
            sentence.Append(".");

            // Convert StringBuilder to usable string
            string finalSentence = sentence.ToString();

            // Print sentence to screen.
            Console.WriteLine(finalSentence);

            // Ask the user if they want another sentence.
            Console.WriteLine("\nAgain? (Y/N)");
            string userInput = Console.ReadLine();
            Console.WriteLine();

            // Go to InsertCoin method to process what the user types in.
            InsertCoin(userInput);
        }
        static void InsertCoin(string yn)
        {
            // Identify first character of the input string, allowing user to type out "yes" or "no" without incident.
            char firstLetter = yn[0];
            // If the first character is y, return to the start of the program.
            if (firstLetter == 'y' || firstLetter == 'Y')
            {
                Console.WriteLine();
                Main();
            }
            // If the first character is n, continue to the end of the program, which automatically closes it.
            else if(firstLetter == 'n' || firstLetter == 'N')
            {
            }
            // If the first character is anything else, print more descriptive instructions, then run the method again with a new user input.
            else
            {
                Console.WriteLine("\nI'm not sure what you mean. Please type Y for another sentence or N to exit.");
                InsertCoin(Console.ReadLine());
            }
        }
    }
}
