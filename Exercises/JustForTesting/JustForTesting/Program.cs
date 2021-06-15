using System;

namespace JustForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Write your first name: ");
            string first_name = Console.ReadLine();
            Console.Write("Write your last name: ");
            string last_name = Console.ReadLine();

            string[] arr = new string[] {first_name, last_name};
            // Loop over strings.
            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i];
                Console.Write(String.Format("{0} ",s));
            }
        }
    }
}
