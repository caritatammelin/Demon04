using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Gravy : Cook
    {
        public string Sauce { get; set; }
        public bool Stockcube { get; set; }
        public string Flour { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Cooking: ");
            Console.WriteLine("- Stove: " + Stove + " Time(min): " + Time + " Spices: " + Spices + " Sauce: " + Sauce + " Stockcube: " + Stockcube + " Flour: " + Flour);
        }
    }
}
