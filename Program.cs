using System;

namespace SpriteProject
{
    class Program
    {
        static void Main(string[] args)
        {                  
            PhoneBook per = new PhoneBook();
            Console.WriteLine("What is your full name?");
            per.FullName = Console.ReadLine();
            Console.WriteLine("What email would you like to use");
            per.Email = Console.ReadLine();
            Console.WriteLine("What number do you want to use");
            per.PhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {per.FullName}, Email:{per.Email}, Phone:{per.PhoneNumber}");
        }   
    }
}
                                                  