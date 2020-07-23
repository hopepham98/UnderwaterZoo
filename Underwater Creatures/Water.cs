using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Globalization;

namespace Underwater_Creatures
{
     class Water
    {
        
        List <Creature> Creatures = new List<Creature> {
        new Shrimp("\nLenny", "A shrimp's heart is located in its head! While, the brain is located in the back or side of the shrimp's head.", "snap", 5, ConsoleColor.Magenta),
        new Starfish("\nPenny", "Starfish eyes and mouth are under their body.", "sing", 6, ConsoleColor.Yellow),
        new Jellyfish("\nSquishy", "When jellyfish swim in large groups, it's known as a bloom.", "buzz", 8, ConsoleColor.Cyan),
        new Octopus("\nTesla", "An octopus has three hearts, nine brains, and blue blood.", "sign language", 15, ConsoleColor.DarkRed),
        new SeaTurtle("\nSurf", "Some sea turtles migrate very long distances while pthers stay close to home.", "chirp", 8, ConsoleColor.DarkGreen),
        new Clownfish("\nNemo", "Cloenfish are small in size. They can reach between 2 and 5 inches in length.", "burbles", 9, ConsoleColor.Red),
        };


        Random random = new Random();

        public Water() 
        {
            WriteLine("Welcome to Underwater Zoo by Hope Pham!\nPlease enjoy the zoo and have fun learning about these mystery underwater creatures.");
            Menu();
        }

        private void Menu()
        {
            //The modifier "private" in this class is one example of encapsulation.

            string input;
            WriteLine("\nWhat would you like to do?");
            WriteLine("\n1) Show all creatures in the water");
            WriteLine("\n2) Choose a specific creature");
            WriteLine("\n3) Feed creatures food");
            WriteLine("\n4) Adopt a sea creature");
            WriteLine("\n5) Exit application");

            WriteLine("\nEnter a number: ");
            input = ReadLine();

            //Player interaction / Menu
            switch (input)
            {
                case "1":
                    ShowAllCreatures();
                    break;

                case "2":
                    ShowCreatureList();
                    break;

                case "3":
                    PassFood();
                  
                    break;

                case "4":
                    AdoptACreature();
                  
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    WriteLine("\nPlease enter one of the choices above. Press enter to continue");
                    ReadKey();
                    Menu();
                    break;
            }
        }
        private void ShowAllCreatures()
        {
            Clear();
          
            foreach (Creature creature in Creatures)
            {
                WriteLine(creature.Name + " : " + creature.Description);
                WriteLine(creature.Talk());
                WriteLine(creature.Dream());
            }
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }

        private void ShowCreatureList()
        {
            Clear();

            for (int i = 0; i < Creatures.Count; i++)
            {
                WriteLine(i + 1 + ") " + Creatures[i].Name);
            }

            WriteLine("Press any key to continue...");
            ReadKey();
        }
        public void PassFood() 
        {
            Clear();
             
            string[] food = new string[] { "paper", "apple", "candy", "watermelon" , "pizza", "fish food", "worm", "ham and cheese sandwich", "sushi", "mango","ramen","dragon fruit"};

            foreach(Creature c in Creatures) 
            {
                c.Eat(food[random.Next(food.Length)]);
            }
        }

        private void AdoptACreature() 
        {
            WriteLine("Welcome to Adopt A Sea Creature, where each adoption you will help by saving endangered sea creatures.\n");

        
            List<Adopt> pet = new List<Adopt>();
            pet.Add(new Adopt("Jellyfish","Jellyfish have no brain, heart, bones or eyes."));
            pet.Add(new Adopt("Clownfish", "Clownfish lives in salt water habitats."));
            pet.Add(new Adopt("Starfish", "Starfish are not fish, but they are actually known as Sea stars, which they belong to a group of animals called echinoderms, meaning spiny skin."));
            pet.Add(new Adopt("SeaTurtle", "Sea turtle are known as the oceans' lawnmowers."));
            pet.Add(new Adopt("Shrimp", "There are about 2,000 different species of shrimp worldwide."));
            pet.Add(new Adopt("Octopus", "Octoppus are known to have very good eyesight and an excellent sense of touch."));


            WriteLine("These are the sea creatures you can adopt:\n");
            int choice = 1;
            foreach(Adopt adopt in pet) 
            {
                WriteLine(choice + ") " + adopt.About());
                choice++;
            }
            string input = ReadLine();
            switch (input) 
            {

                case "1":
                    Pet(0);
                    break;

                case "2":
                    Pet(1);
                    break;

                case "3":
                    Pet(2);
                    break;


                case "4":
                    Pet(3);
                    break;

                case "5":
                    Pet(4);
                    break;

                case "6":
                    Pet(5);
                    break;
                   

            }
           

        } 

        private void Pet(int choice)
        {
            Clear();

            WriteLine("Would you like to adopt this sea creature?");
            string input = ReadLine();

            if (input.ToLower() == "yes")
            {
                TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;

                WriteLine("Great choice! What name would you like to give your new sea creature?");

                string name = ReadLine();
                name = TitleCase.ToTitleCase(name);
                WriteLine("\nYour pets is now known as " + name);

                WriteLine("\nWhat trait do you want your sea creature to have?");

                string trait = ReadLine();
                WriteLine(name + " has obtain " + trait + " as a trait!\n");

            }
           
                    
            

            WriteLine("Press any key to exit.");
            ReadKey();

            ReadKey();

        }
    }
  
    
  
}