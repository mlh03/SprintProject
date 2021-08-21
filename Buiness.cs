using System;
namespace SpriteProject
{
    public class Buiness : PhoneBook
    {

        public string CompanyName { get; set; }


        public override void PrintMethod()
        {
            Console.WriteLine($"BUINESS CONTACT:" +
               $" Name: {FullName}," +
               $" Company Name: {CompanyName}," +
               $" Email: {Email}," +
               $" Phone Number: {PhoneNumber}");
        
        }
    }
}
