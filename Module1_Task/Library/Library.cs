using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Task.Library
{
    internal class Library
    {
        private LibraryItem.LibraryItem[] _items;

        public Library()
        {
            _items = new LibraryItem.LibraryItem[]
    {
                new Book.Book("George Orwell", "1984", new DateTime(2024, 4, 24)),
                new Book.Book("Arthur Conan Doyle", "Sherlock Holmes", new DateTime(2024, 4, 24)),
                new Journal.Journal("The Economist", new DateTime(2024, 4, 24), "Magazine, Businnes")
    };

          

        }

        public LibraryItem.LibraryItem[] GetItems()
        {
            return _items;
        }

        public LibraryItem.LibraryItem[] SetItems(LibraryItem.LibraryItem value)
        {

            _items = [.. _items, value];
            return _items;
            
        }


        public void DeleteItem(string bookName)
        {
            var items =  _items.Where(c=> c.Name != bookName).ToArray(); 
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            _items = items;
        }
    }
}
