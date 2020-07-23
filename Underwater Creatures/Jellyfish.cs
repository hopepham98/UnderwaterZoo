using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Console;

namespace Underwater_Creatures
{
    class Jellyfish : Creature
    {
       

        public Jellyfish()
        {
        }
        public Jellyfish(string name, string description, string interact, int sleep, ConsoleColor color) 
        {
            Name = name;
            Description = description;
            Interact = interact;
            Sleep = sleep;
            
            

            

        }
    }
}