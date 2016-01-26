using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Cook
    {
        private readonly int maxStove = 6;
        private readonly int minStove = 0;
        private int stove;

        public int Stove
        {
            get
            {
                return stove;
            }
            set
            {
                if (value <= maxStove && value >= minStove) stove = value;
                else
                {
                    Console.WriteLine("No such value.");
                    stove = minStove;
                }
            }

        }

        private readonly int maxTime = 60;
        private readonly int minTime = 0;
        private int time;
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                if (value <= maxTime && value >= minTime) time = value;
                else
                {
                    Console.WriteLine("You just ruined your cuisine.");
                    time = minTime;
                }
            }
        }

        public string Spices { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Cooking: ");
            Console.WriteLine("- Stove: " + Stove + " Time(min): " + Time + " Spices: " + Spices);
        }
    }
}
