using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Radio
    {
        public bool Switch { get; set; }

        // volume

        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume) volume = value;
                else
                {
                    Console.WriteLine("Volume too high!");
                    volume = minVolume;
                }
                if (value >= minVolume) volume = value;
                else
                {
                    Console.WriteLine("Volume too low!");
                    volume = minVolume;
                }

            }
        }


        // taajuus 2000.0-26000.0
        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 2000.0;
        private double frequency;
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value <= maxFrequency && value >= minFrequency) frequency = value;
                else
                {
                    Console.WriteLine("Wrong frequency!");
                    frequency = minFrequency;
                }
            }
        }

    }
}
