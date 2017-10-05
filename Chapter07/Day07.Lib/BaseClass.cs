using static System.Console;

namespace Day07.Lib
{
    public class BaseClass
    {
        internal string ReviewerName = "Shivprasad Koirala";
    }

    public class ChildClass : BaseClass
    {
        public void Display()
        {
            Write("This internal members of BaseClass is visible here:");
            WriteLine($"{nameof(ReviewerName)} is '{ReviewerName}'");
        }
    }
}
