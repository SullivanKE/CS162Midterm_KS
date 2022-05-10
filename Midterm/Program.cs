using System;

namespace CS162NMidterm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eliza will see you now.");

            Console.WriteLine("Eliza: Please, tell me what is troubling you.");
            
            string userInput = Console.ReadLine();
            Console.WriteLine(CreateElizaResponse(userInput));

            userInput = Console.ReadLine();
            Console.WriteLine(CreateElizaResponse(userInput));

            userInput = Console.ReadLine();
            Console.WriteLine(CreateElizaResponse(userInput));
        }

        static string CreateElizaResponse(string statement)
        {
            string response = "";
            string[] fillerResponses = new string[] { "Please go on.", "Tell me more.", "Continue." };
            Random random = new Random();
            statement = statement.Trim();
            statement = statement.ToLower();

            if (statement.IndexOf("my") != -1)
                response = "Tell me more about your " + statement.Substring(statement.IndexOf("my") + 3);
            else if (statement.IndexOf("love") != -1 || statement.IndexOf("hate") != -1)
                response = "You have strong feelings about that!";
            else
                response = fillerResponses[random.Next(fillerResponses.Length)];

            return response;
        }

    }
}