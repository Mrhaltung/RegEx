using System;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");
            Console.WriteLine("Write your Mobile Number ex : +91 7891235452 .");
            Console.Write("\n Enter Mobile Number : ");
            string name = Console.ReadLine();
            Patterns.MobileNumber(name);
        }
    }
}
