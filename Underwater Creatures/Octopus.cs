using System;
using System.Collections.Generic;
using System.Text;

namespace Underwater_Creatures
{
    public class Octopus : Creature
    {
        public Octopus()
        {
        }
        public Octopus(string name, string description, string interact, int sleep, ConsoleColor color)
        {
            Name = name;
            Description = description;
            Interact = interact;
            Sleep = sleep;

        }
    }
}