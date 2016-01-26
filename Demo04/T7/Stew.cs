using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Stew : Cook
    {
        public string Vegetables { get; set; }
        public string Meat { get; set; }

        public Stew(string vegetables, string meat)
        {
            Vegetables = vegetables;
            Meat = meat;
        }

        public void PrintData()
        {
            Console.WriteLine("Cooking: ");
            Console.WriteLine("- Stove: " + Stove + " Time(min): " + Time + " Spices: " + Spices + " Veggies: " + Vegetables + " Meat: " + Meat);
        }
    }
}
