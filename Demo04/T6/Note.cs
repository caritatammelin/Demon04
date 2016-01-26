using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Note : Book
    {
        public bool Lines { get; set; }
        public bool Empty { get; set; }

        public Note(string name, string covers)
            : base(name, covers)
        {

        }

        public void PrintData()
        {
            Console.WriteLine("Notebook: ");
            Console.WriteLine("- Name: " + Name + " Covers: " + Covers + " Pictures: " + Pictures + " Pages: " + Pages + " Lines: " + Lines + " Empty: " + Empty);
        }
    }
}
