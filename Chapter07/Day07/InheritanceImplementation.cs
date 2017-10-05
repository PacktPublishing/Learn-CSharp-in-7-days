using static System.Console;
namespace Day07
{
    public class InheritanceImplementation
    {}

    public interface IBook
    {
        string Title { get; set; }
        string Isbn { get; set; }
        bool Ispublished { get; set; }
        void Detail();
    }
    public class Person
    {
        public string FirstName { get; set; } = "Gaurav";
        public string LastName { get; set; } = "Aroraa";
        public int Age { get; set; } = 43;
        public string Name => $"{FirstName} {LastName}";

        public virtual void Detail()
        {
            WriteLine("Person's Detail:");
            WriteLine($"Name: {Name}");
            WriteLine($"Age: {Age}");
            ReadLine();
        }
    }

    public class Author:Person, IBook
    {
        public string Title { get; set; }
        public string Isbn { get; set; }
        public bool Ispublished { get; set; }
        public override void Detail()
        {
            WriteLine("Author's detail:");
            WriteLine($"Name: {Name}");
            WriteLine($"Age: {Age}");
            ReadLine();
        }
        void IBook.Detail()
        {
            WriteLine("Book details:");
            WriteLine($"Author Name: {Name}");
            WriteLine($"Author Age: {Age}");
            WriteLine($"Title: {Title}");
            WriteLine($"Isbn: {Isbn}");
            WriteLine($"Published: {(Ispublished ? "Yes" : "No")}");
            ReadLine();
        }
    }

    public class Editor : Person
    {
        public override void Detail()
        {
            WriteLine("Editor's detail:");
            WriteLine($"Name: {Name}");
            WriteLine($"Age: {Age}");
            ReadLine();
        }
    }

    public class Reviewer : Person
    {
        public override void Detail()
        {
            WriteLine("Reviewer's detail:");
            WriteLine($"Name: {Name}");
            WriteLine($"Age: {Age}");
            ReadLine();
        }
    }
}