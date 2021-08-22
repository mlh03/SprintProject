using System;

namespace SpriteProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //PHONEBOOK CLASS:
            //PhoneBook per = new PhoneBook();
            //Console.WriteLine("What is your full name?");
            //per.FullName = Console.ReadLine();
            //Console.WriteLine("What email would you like to use");
            //per.Email = Console.ReadLine();
            //Console.WriteLine("What number do you want to use");
            //per.PhoneNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Name: {per.FullName}, Email:{per.Email}, Phone:{per.PhoneNumber}");

            ////INHERANTNCE:
            //Friend per = new Friend();
            //Console.WriteLine("what is the nick name?");
            //per.NickName = Console.ReadLine();
            //Console.WriteLine("What is your full name?");
            //per.FullName = Console.ReadLine();
            //Console.WriteLine("What email would you like to use");
            //per.Email = Console.ReadLine();
            //Console.WriteLine("What number do you want to use");
            //per.PhoneNumber = int.Parse(Console.ReadLine());

            //per.PrintMethod();


            //Buiness par = new Buiness();
            //Console.WriteLine("What is your company name?");
            //par.CompanyName = Console.ReadLine();
            //Console.WriteLine("What is your full name?");
            //par.FullName = Console.ReadLine();
            //Console.WriteLine("What email would you like to use");
            //par.Email = Console.ReadLine();
            //Console.WriteLine("What number do you want to use");
            //par.PhoneNumber = int.Parse(Console.ReadLine());

            //INTERFACES

            PhoneBook par = new PhoneBook();
            Console.WriteLine("What is your company name?");
            par.CompanyName = Console.ReadLine();
            Console.WriteLine("What is your nickname?");
            par.NickName = (Console.ReadLine());
            Console.WriteLine("What is your full name?");
            par.FullName = Console.ReadLine();
            Console.WriteLine("What email would you like to use");
            par.Email = Console.ReadLine();
            Console.WriteLine("What number do you want to use");
            par.PhoneNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine(par.PrintCompany());
            Console.WriteLine(par.PrintNickName());

        }

    }
}
                                                  