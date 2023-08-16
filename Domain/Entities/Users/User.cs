using Domain.Base;

namespace Domain.Entities.Users
{
    public class User : Trackable
    {
        public string Username { get; set; }

        public string Email { get; set; }
    }
}
