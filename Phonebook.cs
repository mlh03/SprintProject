using System;
namespace SpriteProject
{
    public abstract class PhoneBook 
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public abstract void PrintMethod();
        
    }
}
