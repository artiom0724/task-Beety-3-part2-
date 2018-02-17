using System;

namespace Beety.Domain.Entity.User
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Login { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime? BirthDay { get; set; }

        public string Photo { get; set; }
    }
}
