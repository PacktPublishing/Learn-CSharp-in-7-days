using System;
using static System.Console;

namespace Day07
{
    public class EncapsulationImplementation
    {
        public void Display()
        {
            WriteLine("Encapsulation example");
            Writer writer = new Writer();
            Write("Enter First Name:");
            var fName = ReadLine();
            Write("Enter Last Name:");
            var lName = ReadLine();
            writer.SetName(fName,lName);
            Write("Book title:");
            writer.SetTitle(ReadLine());
            Write("Enter ISBN:");
            writer.SetIsbn(ReadLine());
            WriteLine("Complete details of book:");
            WriteLine(writer.ToString());
        }

    }

    internal class Writer
    {
        private string _title;
        private string _isbn;
        private string _name;

        public void SetName(string fname, string lName)
        {
            if (string.IsNullOrEmpty(fname) || string.IsNullOrWhiteSpace(lName))
                throw new ArgumentException("Name can not be blank.");

            _name = $"{fname} {lName}";
        }

        public void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Book title can not be blank.");
            _title = title;
        }

        public void SetIsbn(string isbn)
        {
            if (!string.IsNullOrEmpty(isbn))
            {
                if (isbn.Length == 10 | isbn.Length == 13)
                {
                    if (!ulong.TryParse(isbn, out _))
                        throw new ArgumentException("The ISBN can consist of numeric characters only.");
                }
                else
                    throw new ArgumentException("ISBN should be 10 or 13 characters numeric string only.");
            }
            _isbn = isbn;
        }

        public override string ToString() => $"Author '{_name}' has authored a book '{_title}' with ISBN '{_isbn}'";
    }
}