using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Story", "Hard covers");
            book.Pictures = true;
            book.Pages = 400;
            book.PrintData();

            Note note = new Note("Notebook", "Soft covers");
            note.Pictures = false;
            note.Pages = 150;
            note.Lines = true;
            note.Empty = true;
            note.PrintData();

            Dictionary dictionary = new Dictionary("Japanese Phrasebook", "Soft covers");
            dictionary.Pictures = true;
            dictionary.Pages = 270;
            dictionary.Languages = "English and Japanese";
            dictionary.CD = true;
            dictionary.PrintData();

            Console.ReadLine();
        }
    }
}
