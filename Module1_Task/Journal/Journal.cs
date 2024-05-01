using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Module1_Task.Journal
{
    internal class Journal :LibraryItem.LibraryItem
    {
        public Journal(string name, DateTime date, string type)
        {
            Name = name;
            Date = date;
            Type = type;
        }

        public string Type { get; set; }
    }
}
