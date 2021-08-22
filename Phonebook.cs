using System;
namespace SpriteProject
{
    public class PhoneBook :  IFriend, IBuiness
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string NickName { get; set ; }
        public string CompanyName { get; set; }


        public string PrintCompany()
        {
            return $"Name: {FullName}, " +
                $" Email: {Email}" +
                $" Phone: {PhoneNumber}" +
                $" Company Name: {CompanyName}";
        }

        public string PrintNickName()
        {
            return $"Name: {FullName}, " +
                $" Email: {Email}" +
                $" Phone: {PhoneNumber}" +
                $" Nick Name: {NickName}";
        }
    }

}
