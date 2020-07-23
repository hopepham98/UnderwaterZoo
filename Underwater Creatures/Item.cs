using System;
using System.Collections.Generic;
using System.Text;

namespace Underwater_Creatures
{
    public class Item : Food
    {
        public Item()
        {
        }
        public Item(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
          

        }
    }
}