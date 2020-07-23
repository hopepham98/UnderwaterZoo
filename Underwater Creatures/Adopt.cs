using System;
using System.Collections.Generic;
using System.Text;

namespace Underwater_Creatures
{
    public class Adopt
    {
        protected string Type = "";
        protected string Detail = "";
        public List<Adopt> Adopts = new List<Adopt>();
        public ConsoleColor LocationColor = new ConsoleColor();

        public Adopt(string type, string detail) 
        {
            Type = type;
            Detail = detail;
        }
     
        public string About()
        {
            return $"{Type}: {Detail}";
        }
    }
}
