using static Beety.Domain.Enums.Enums;

namespace Beety.Domain.Entity.User
{
    public class Redactor : User
    {
        public UserRole UserRole { get; set; }//Administrator or Moderator
    }
}
