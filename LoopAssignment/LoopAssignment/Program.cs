using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Who is the eldest sister? Nicole, Shauna or Shannon:");
            string eldest = Console.ReadLine();
            bool isGuessed = eldest == "Shauna";

            do
            {
                switch (eldest)
                {
                    case "Nicole":
                    case "nicole":
                        Console.WriteLine("You guessed Nicole, try again.");
                        Console.WriteLine("Who is the eldest sister? Nicole, Shauna or Shannon:");
                        eldest = Console.ReadLine();
                        break;
                    case "Shauna":
                    case "shauna":
                        Console.WriteLine("You guessed right! Shauna is the eldest.");
                        isGuessed = true;
                        break;
                    case "Shannon":
                    case "shannon":
                        Console.WriteLine("You guessed Shannon, try again.");
                        Console.WriteLine("Who is the eldest sister? Nicole, Shauna or Shannon:");
                        eldest = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please pick one of the names provided.");
                        Console.WriteLine("Who is the eldest sister? Nicole, Shauna or Shannon:");
                        eldest = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);
            
            Console.Read();

        }
    }
}
