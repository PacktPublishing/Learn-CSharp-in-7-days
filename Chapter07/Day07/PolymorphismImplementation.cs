using System;
using System.Collections.Generic;
using static System.Console;

namespace Day07.Polymorphism
{
    public class PolymorphismImplementation
    {
        public void Build()
        {
            List<Team> teams = new List<Team> {new Author(), new Editor(), new Reviewer()};
            foreach (Team team in teams)
                team.BuildTeam();
        }
    }

    public class Team
    {
        public string Name { get; private set; }
        public string Title { get; private set; }

        public virtual void BuildTeam()
        {
            Write("Name:");
            Name = ReadLine();
            Write("Title:");
            Title = ReadLine();
            WriteLine();
            WriteLine($"Name:{Name}\nTitle:{Title}");
            WriteLine();
        }
    }

    internal class Author : Team
    {
        public override void BuildTeam()
        {
            WriteLine("Building Author Team");
            base.BuildTeam();
        }
    }

    internal class Editor : Team
    {
        public override void BuildTeam()
        {
            WriteLine("Building Editor Team");
            base.BuildTeam();
        }
    }

    internal class Reviewer : Team
    {
        public override void BuildTeam()
        {
            WriteLine("Building Reviewer Team");
            base.BuildTeam();
        }
    }
}

namespace Day07.Polymorphism.CompileTime
{
    public class CompileTimePolymorphismImplementation
    {
        public void Run()
        {
            Write("Enter first number:");
            var num1 = ReadLine();
            Write("Enter second number:");
            var num2 = ReadLine();
            Math math = new Math();
            var sum1 = math.Add(FloatToInt(num1), FloatToInt(num1));
            var sum2 = math.Add(ToFloat(num1), ToFloat(num2));
            WriteLine("Using Addd(int num1, int num2)");
            WriteLine($"{FloatToInt(num1)} + {FloatToInt(num2)} = {sum1}");
            WriteLine("Using Add(double num1, double num2)");
            WriteLine($"{ToFloat(num1)} + {ToFloat(num2)} = {sum2}");
        }

        private int FloatToInt(string num) => (int)System.Math.Round(ToFloat(num), 0);

        private float ToFloat(string num) => float.Parse(num);
    }
    public class Math
    {
        public int Add(int num1, int num2) => num1 + num2;

        public double Add(double num1, double num2) => num1 + num2;
    }
}

namespace Day07.Polymorphism.RunTime.Abstract
{

    public class RunTimePolymorphismImplementationusingAbstractClass
    {
        public void Run()
        {
            Write("Enter name:");
            var name = ReadLine();
            Author author = new Author(name);
            WriteLine(author.Detail());
        }
    }

    internal abstract class Team
    {
        public abstract string Detail();
    }

    internal class Author : Team
    {
        private readonly string _name;
        
        public Author(string name) => _name = name;

        public override string Detail()
        {
            WriteLine("Author Team:");
            return $"Member name: {_name}";
        }
    }
}

namespace Day07.Polymorphism.RunTime.AbstractVirtual
{
    public class RunTimePolymorphismImplementationusingAbstractVirtual
    {
        public void Run()
        {
            Write("Enter author name:");
            var authorName = ReadLine();
            Write("Enter editor name:");
            var editorName = ReadLine();
            Client client = new Client();
            Author author = new Author(authorName);
            Editor editor = new Editor(editorName);
            WriteLine();
            WriteLine("Authors detail:");
            client.ShowDetail(author);
            WriteLine();
            WriteLine("Editors detail:");
            client.ShowDetail(editor);
        }
    }

    internal class Team
    {
        protected string Name;

        public Team(string name)
        {
            Name = name;
        }

        public virtual string Detail() => Name;
    }

    internal class Author : Team
    {
        public Author(string name) : base(name)
        {}

        public override string Detail() => Name;
    }

    internal class Editor : Team
    {
        public Editor(string name) : base(name)
        {}

        public override string Detail() => Name;
    }

    internal class Client
    {
        public void ShowDetail(Team team) => WriteLine($"Member: {team.Detail()}");
    }
}