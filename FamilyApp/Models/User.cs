using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyApp.Models
{
    public class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public User (string name)
        {
            Name = name;
        }

    }
}
