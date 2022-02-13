using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InputReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = GetBooks();
            books.ForEach(book => Console.WriteLine(book));
            Console.WriteLine($"There are {books.Count()} in the file.");
            Console.ReadKey();
        }

        private static List<Book> GetBooks()
        {
            // Create a list to collect the books.
            List<Book> result = new List<Book>();

            foreach (var line in File.ReadAllLines("../../../books.csv").Skip(2)) // Read the lines of "konyvek.csv" from the root folder. Skip the first 2 lines.
            {
                Book book = new Book(line); // Create a new book object, with data from the read line.
                result.Add(book); // Add newly created book to list.
            }

            return result;
        }
    }
}
