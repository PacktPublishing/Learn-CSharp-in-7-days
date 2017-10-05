using static System.Console;

namespace Day07
{
    public class MemberVisibility
    {
        public void Display()
        {
            WriteLine("Member visibility");
            //PrivateNProtectedMemberExample();
           // InternalMemberExample();
            PublicMemberExample();
            ReadLine();
        }

        private void PrivateNProtectedMemberExample()
        {
            new BaseClass.DeriveClass().Display();
        }

        private void InternalMemberExample()
        {
            var childClass = new Lib.ChildClass();
            WriteLine("Calling from derived class that belongs to same assembly of BaseClass");
            childClass.Display();
        }

        private void PublicMemberExample()
        {
            ChildClassYounger childClassYounger = new ChildClassYounger();
            childClassYounger.Display();
        }


    }

    public class BaseClass
    {
        private const string AuthorName = "Gaurav Aroraa";
        protected string EditorName = "Vikas Tiwari";

        public class DeriveClass : BaseClass
        {
            public void Display()
            {
                Write("This is from inherited Private member:");
                WriteLine($"{nameof(AuthorName)}'{AuthorName}'");
                ReadLine();
            }
        }
    }

    public class ChildClass : BaseClass
    {
        public void Display()
        {
            //Write("This inherited Private member is not visible here:");
            //WriteLine($"{nameof(AuthorName)}'{AuthorName}'");

            Write("This Protected member is visible here:");
            WriteLine($"{nameof(EditorName)} is '{EditorName}'");

            //BaseClass baseClass = new BaseClass();
            //Write("This Protected member is not visible here:");
            //WriteLine($"{nameof(baseClass.EditorName)}'{baseClass.EditorName}'");
            
        }
    }

    public class ChildClassofExternalBaseClass : Lib.BaseClass
    {
        public void Display()
        {
            Write("This internal members of Lib.BaseClass is not visible here:");
            // WriteLine($"{nameof(ReviewerName)} is '{ReviewerName}'");
        }
    }

    public class ChildClassYounger : ChildClass
    {
        private string _copyEditor = "Diwakar Shukla";

        public new void Display()
        {
            WriteLine($"This is from ChildClassYounger: copy editor is '{_copyEditor}'");
            WriteLine("This is from ChildClass:");
            base.Display();
        }
    }
}