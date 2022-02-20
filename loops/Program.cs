using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();

            char[] arr = str.ToCharArray();
             Array.Reverse(arr);
            string str_reverse = new string(arr);

            if (str.ToLower() == str_reverse.ToLower())
            {
                Console.WriteLine("Given string is palindrome");
            }
            else
            {
                Console.WriteLine("Given string is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
