using System;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002,
                "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case (old)", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var b in libraryTwo)
            {
                Console.WriteLine(b.Title);
            }

            //Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            //Book bookTwo = new Book("The Documents in the Case", 2003, "Dorothy Sayers", "Robert Eustace");
            //Book bookThree = new Book("The Documents in the Case", 1930);
            //Book bookFour = new Book("The Documents in the Case", 1900, "Dorothy Sayers", "Robert Eustace");
            //Book bookFive = new Book("whe Documents in the Case", 1900, "Dorothy Sayers", "Robert Eustace");

            //Library libraryOne = new Library();
            //Library libraryTwo = new Library(bookOne, bookTwo, bookThree, bookFour, bookFive);
            //Library library = new Library(bookOne, bookTwo, bookThree);

            //var books = library.ToArray();
            //Array.Sort(books, new BookComparator());

            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}

        }
    }
}
