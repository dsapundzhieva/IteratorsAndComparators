using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.Books = books.ToList();
        }
        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            this.Books.Sort();
            for (int i = 0; i < this.Books.Count; i++)
            {
                yield return this.Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //public IEnumerator<Book> GetEnumerator()
        //{
        //    return new LibraryIterator(this.Books);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}

        //class LibraryIterator : IEnumerator<Book>
        //{
        //    private List<Book> books;
        //    private int currentÏndex;

        //    public LibraryIterator(List<Book> books)
        //    {
        //        this.books = books;
        //        this.Reset();
        //    }

        //    public Book Current => this.books[currentÏndex];

        //    object IEnumerator.Current => this.Current;

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        this.currentÏndex++;
        //        return currentÏndex < this.books.Count;
        //    }

        //    public void Reset()
        //    {
        //        this.currentÏndex = -1;
        //    }
        //}
    }
}
