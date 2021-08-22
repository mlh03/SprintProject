using System;
namespace SpriteProject
{
    public interface IBuiness
    {
        public string CompanyName { get; set; }

        public string PrintCompany();
   
    }
}
