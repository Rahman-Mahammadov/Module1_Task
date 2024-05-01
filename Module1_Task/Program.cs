using Module1_Task.Book;
using Module1_Task.Journal;
using Module1_Task.Library;
using Module1_Task.LibraryItem;

internal class Program
{



    private static void Main(string[] args)
    {
        var userName = "Rahman";
        var userPassword = "salam123";

        Console.WriteLine("Enter your credentials");

        var enteredName = Console.ReadLine();
        var enteredPassword = Console.ReadLine();
        bool ended = true;
        string[] operations = { "Show the books", "Add a book", "Rent a book" };

        if (userName == enteredName && userPassword == enteredPassword)
        {
            Console.WriteLine("Successfully registered \r\n");

            Library library1 = new Library();

            while (ended)
            {






                for (int i = 0; i < operations.Length; i++)
                {
                    Console.WriteLine($"{i+1} {operations[i]}");
                    
                }

                Console.WriteLine();
                if (int.TryParse(Console.ReadLine(), out int secim))
                {
                    switch (secim)
                    {
                        case 1:
                            LibraryItem[] books = library1.GetItems();
                            Console.Clear();
                            foreach (LibraryItem book in books)
                            {
                                Console.WriteLine(book.Name);

                            }

                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("\r\n 1) Journal \r\n 2) Book");
                            var bookChoice = int.Parse(Console.ReadLine());
                            if (bookChoice == 1)
                            {
                                Console.WriteLine("Write the author's name");
                                string author = Console.ReadLine();

                                Console.WriteLine("Write the name of the book");
                                string name = Console.ReadLine();

                                Console.WriteLine("When was the book published?");
                                var date = DateTime.Parse(Console.ReadLine());

                                Book book = new Book(author, name, date);


                                Console.Clear();

                                LibraryItem[] SetBooks = library1.SetItems(book);
                                foreach (LibraryItem newBook in SetBooks)
                                {
                                    Console.WriteLine(newBook.Name);

                                }

                                Console.WriteLine();
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter the name of the book you want to rent");
                            var BookName = Console.ReadLine();
                            Console.Clear();

                            

                            library1.DeleteItem(BookName);

                            break;
                    }

                }
            }
        }
    }
}