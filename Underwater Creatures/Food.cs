using System;
using System.Collections.Generic;
using System.Text;

namespace Underwater_Creatures
{
    public class Food
    {
        public string Name;
        public string Description;
        public string Type;

        public Food() 
        {
        }
        public Food(string name, string description, string type) 
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }
}