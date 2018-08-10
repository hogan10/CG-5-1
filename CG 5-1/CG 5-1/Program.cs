using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //We first ask them to enter their first name
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            //next we ask them to enter their last name
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            //finally we want the name to be written back onto the screen. This can be done using a second method and calling the method below
            Console.Write("Your name: ");
            PrintFirstLast(firstName);
            PrintFirstLast(lastName);
            Console.ReadLine();
        }
        /// <summary>
        /// this method writes the full name out above
        /// </summary>
        /// <param name="message"></param>
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
