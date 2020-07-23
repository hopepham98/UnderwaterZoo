using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console; 

namespace Underwater_Creatures
{
    public class Creature
    {
        public string Name = "";
        public string Description = "";
        public string Interact;
        public int Sleep;
        ConsoleColor Color;

       

        public Creature() 
        {
            //This is an example of polymorphism.
        }
        public Creature(string name, string description, string interact, int sleep, ConsoleColor color)
        {

            Name = name;
            Description = description;
            Interact = interact;
            Sleep = sleep;
            Color = color;

        }
        public string Talk() 
        {
            return $"{Name} {Interact}.";
        }
        public string Dream()
        {
            return $"{Name} sleep {Sleep} hours.";
        }

        public void Eat(string food)
        {
            WriteLine(Name + " eats " + food  + ".\n");
           
        }
    }
}