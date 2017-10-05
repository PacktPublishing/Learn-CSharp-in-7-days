using static System.Console;

namespace Day07
{
    public class AbstractionImplementation
    {
        public void Display()
        {
            BookAuthor author = new BookAuthor();
            author.GetDetail();
            BookEditor editor = new BookEditor();
            editor.GetDetail();
            BookReviewer reviewer = new BookReviewer();
            reviewer.GetDetail();
        }
    }

    public abstract class Team
    {
        public abstract void GetDetail();
    }

    public class BookAuthor : Team
    {
        public override void GetDetail() => Display();

        private void Display()
        {
            WriteLine("Author detail");
            Write("Enter Author Name:");
            var name = ReadLine();
            WriteLine($"Book author is: {name}");
        }
    }

    public class BookEditor : Team
    {
        public override void GetDetail() => Display();

        private void Display()
        {
            WriteLine("Editor detail");
            Write("Enter Editor Name:");
            var name = ReadLine();
            WriteLine($"Book editor is: {name}");
        }
    }

    public class BookReviewer : Team
    {
        public override void GetDetail() => Display();

        private void Display()
        {
            WriteLine("Reviewer detail");
            Write("Enter Reviewer Name:");
            var name = ReadLine();
            WriteLine($"Book reviewer is: {name}");
        }
    }
}