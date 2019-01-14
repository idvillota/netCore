using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ExtendedModels
{
    public class UserExtended : IEntity
    {
        public decimal Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public UserExtended()
        {

        }

        public UserExtended(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Password = user.Password;
        }
    }
}
