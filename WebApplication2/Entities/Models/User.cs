using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class User : IEntity
    {
        public decimal Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}
