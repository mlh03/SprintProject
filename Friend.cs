using System;
namespace SpriteProject
{
    public class Friend : PhoneBook
    {
        public string NickName { get; set; }

        public override void PrintMethod()
        {
            Console.WriteLine($"FRIEND CONTACT:" +
               $" Name: {FullName}," +
               $" Email: {Email}" +
               $" Phone: {PhoneNumber}" +
               $" Nick Name: {NickName}");

        }
    }
}
