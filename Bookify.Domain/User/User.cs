using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.User
{
    public sealed class User : Entity
    {
        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }

        public Email Email { get; private set; }

        private User(Guid id,FirstName firstName,LastName lastName,Email email) 
                :base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public static User Create(FirstName firstName,LastName lastName,Email email)
        {
            var user = new User(Guid.NewGuid(),firstName,lastName,email);

            return user;
        }
    }
}
