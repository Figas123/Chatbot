using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            string question, response;
            while (true)
            {
                Console.WriteLine("What do you want to ask me?");
                question = Console.ReadLine();
                switch (question)
                {
                    case "Hello":
                        response = "Hi";
                        break;
                    case "What is the meaning of everything?":
                        response = "42";
                        break;
                    case "2+2?":
                        response = "2 plus 2 is 4 minus 1 thats 3 quick maths";
                        break;
                    case "EXIT":
                        response = "EXIT";
                        break;
                    default:
                        response = "Output not found, please try again";
                        break;
                }
                if (response != "EXIT")
                {
                    Console.WriteLine("\t" + response + "\n");
                    continue;
                }
                else if (response == "EXIT")
                {
                    Console.WriteLine("Ok, i didnt want to talk with you anyways...\n");
                    break;
                }
            }
        }
    }
}
