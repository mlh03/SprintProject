using System;
namespace SpriteProject
{
    public interface IFriend
    {
        public string NickName { get; set; }

        public string PrintNickName();
    }
}
