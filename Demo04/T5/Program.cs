using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
        
                Radio radio = new Radio();
                radio.Switch = true;
            radio.Frequency = 4000.0;
            radio.Volume = 4;

              
                Console.ReadLine();

            }
        
    }
}
