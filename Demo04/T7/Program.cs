using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook();
            cook.Stove = 4;
            cook.Time = 25;
            cook.Spices = "salt and pepper";
            cook.PrintData();

            Stew stew = new Stew("carrots, onion", "veal");
            stew.Stove = 5;
            stew.Time = 30;
            stew.Spices = "salt, pepper and garlic";
            stew.PrintData();

            Gravy gravy = new Gravy();
            gravy.Stove = 3;
            gravy.Time = 40;
            gravy.Spices = "herbs, salt";
            gravy.Sauce = "cream";
            gravy.Stockcube = true;
            gravy.Flour = "wheat flour";
            gravy.PrintData();

            Console.ReadLine();
        }
    }
}
