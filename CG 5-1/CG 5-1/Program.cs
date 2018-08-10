using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Your name: ");
            PrintFirstLast(firstName);
            PrintFirstLast(lastName);
            Console.ReadLine();
        }

        private static void PrintFirstLast(string message)
        {
            char[] messageArray = message.ToCharArray();
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
         
        }
    }
}
