using System;
using System.Collections.Generic;
using System.Text;

namespace Underwater_Creatures
{
    public class Shrimp : Creature
    {
        public Shrimp() 
        {
            //Above is one example of inheritance. EX. Shrimp : Creature
        }
        public Shrimp(string name, string description, string interact, int sleep, ConsoleColor color) 
        {
            Name = name;
            Description = description;
            Interact = interact;
            Sleep = sleep;
        }
    }
}