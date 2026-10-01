using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyApp.Models
{
    public class ShoppingList
    {
        public List<string> Items { get; set; } = new();
        public DateTime DueDate { get; set; }

    }
}
