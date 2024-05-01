using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Module1_Task.Book
{
    internal class Book: LibraryItem.LibraryItem
    {
        public Book(string author, string name, DateTime date)
        {
            Author = author;
            Name = name;
            Date = date;
        }

        public string Author { get; set; }
    }
}
