using System;
using Day07.Polymorphism;
using Day07.Polymorphism.CompileTime;
using Day07.Polymorphism.RunTime.Abstract;
using Day07.Polymorphism.RunTime.AbstractVirtual;
using static System.Console;

namespace Day07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ValueTypeMenu();
        }

        private static void ValueTypeMenu()
        {
            int userInput;
            do
            {
                userInput = DisplayMenu();
                switch (userInput)
                {
                    case 1:
                        Clear();
                        MemberVisibilityExample();
                        PressAnyKey();
                        break;
                    case 2:
                        Clear();
                        InheritanceImplementationExample();
                        PressAnyKey();
                        break;
                    case 3:
                        Clear();
                        EncapsulationImplementationExample();
                        PressAnyKey();
                        break;
                    case 4:
                        Clear();
                        AbstractionImplementationExample();
                        PressAnyKey();
                        break;
                    case 5:
                        Clear();
                        PolymorphismImplementationExample();
                        PressAnyKey();
                        break;
                    case 6:
                        Clear();
                        CompileTimePolymorphismImplementationExample();
                        PressAnyKey();
                        break;
                    case 7:
                        Clear();
                        RunTimePolymorphismImplementationExample();
                        PressAnyKey();
                        break;
                    case 8:
                        Clear();
                        RunTimePolymorphismImplementationusingAbstractVirtualExample();
                        PressAnyKey();
                        break;
                }
            } while (userInput != 9);
        }

        private static void RunTimePolymorphismImplementationusingAbstractVirtualExample()
        {
            WriteLine("RunTime Polymorphism Implementationusing Abstract Virtual");
            WriteLine();
            RunTimePolymorphismImplementationusingAbstractVirtual implementationusingAbstractVirtual = new RunTimePolymorphismImplementationusingAbstractVirtual();
            implementationusingAbstractVirtual.Run();
        }

        private static void RunTimePolymorphismImplementationExample()
        {
            WriteLine("RunTime Polymorphism Implementation Example");
            WriteLine();
            RunTimePolymorphismImplementationusingAbstractClass implementationusingAbstractClass = new RunTimePolymorphismImplementationusingAbstractClass();
            implementationusingAbstractClass.Run();
        }

        private static void CompileTimePolymorphismImplementationExample()
        {
            WriteLine("CompileTime Polymorphism Implementation Example");
            WriteLine();
            CompileTimePolymorphismImplementation implementation= new CompileTimePolymorphismImplementation();
            implementation.Run();
        }

        private static void PolymorphismImplementationExample()
        {
            WriteLine("Polymorphism Implementation Example");
            WriteLine();
            PolymorphismImplementation implementation  = new PolymorphismImplementation();
            implementation.Build();
        }

        private static void AbstractionImplementationExample()
        {
            WriteLine("Abstraction Implementation Example");
            WriteLine();
            AbstractionImplementation abstractionImplementation = new AbstractionImplementation();
            abstractionImplementation.Display();
        }

        private static void EncapsulationImplementationExample()
        {
            WriteLine("Encapsulation Implementation Example");
            WriteLine();
            EncapsulationImplementation encapsulationImplementation = new EncapsulationImplementation();
            encapsulationImplementation.Display();
        }


        private static void MemberVisibilityExample()
        {
            WriteLine("Member Visibility Example");
            WriteLine();
            var memberVisibility = new MemberVisibility();
            memberVisibility.Display();
        }

        private static void InheritanceImplementationExample()
        {
            WriteLine("Inheritance Implementation Example");
            WriteLine();
            var person = new Person();
            WriteLine("Parent class Person:");
            person.Detail();
            var author = new Author();
            WriteLine("Derive class Author:");
            Write("First Name:");
            author.FirstName = ReadLine();
            Write("Last Name:");
            author.LastName = ReadLine();
            Write("Age:");
            author.Age = Convert.ToInt32(ReadLine());
            author.Detail();

            var editor = new Editor();
            WriteLine("Derive class Editor:");
            Write("First Name:");
            editor.FirstName = ReadLine();
            Write("Last Name:");
            editor.LastName = ReadLine();
            Write("Age:");
            editor.Age = Convert.ToInt32(ReadLine());
            editor.Detail();

            var reviewer = new Reviewer();
            WriteLine("Derive class Reviewer:");
            Write("First Name:");
            reviewer.FirstName = ReadLine();
            Write("Last Name:");
            reviewer.LastName = ReadLine();
            Write("Age:");
            reviewer.Age = Convert.ToInt32(ReadLine());
            reviewer.Detail();

            //multiple Inheritance
            WriteLine("Book details:");
            Write("Title:");
            author.Title = ReadLine();
            Write("Isbn:");
            author.Isbn = ReadLine();
            Write("Published (Y/N):");
            author.Ispublished = ReadLine() == "Y";
            ((IBook)author).Detail(); //we need to cast as both Person class and IBook has same named methods
        }

        private static void PressAnyKey()
        {
            Write("Press any key...");
            ReadKey();
            Clear();
        }

        private static int DisplayMenu()
        {
            return Convert.ToInt32(SelectedMenu());
        }
        private static int SelectedMenu()
        {
            WriteLine("Example - Day 07: Learning C# in 7-days");
            WriteLine();
            WriteLine("1. Member Visibility Example");
            WriteLine("2. Inheritance Implementation Example");
            WriteLine("3. Encapsulation Implementation Example");
            WriteLine("4. Abstraction Implementation Example");
            WriteLine("5. Polymorphism Implementation Example");
            WriteLine("6. CompileTime Polymorphism Implementation Example");
            WriteLine("7. RunTime Polymorphism Implementation Example");
            WriteLine("8. RunTime Polymorphism Implementationusing AbstractVirtual Example");
            WriteLine("9. Exit");
            Write("Enter choice (1-9): ");
            var result = ReadLine();
            return string.IsNullOrEmpty(result) ? 0 : Convert.ToInt32(result);
        }
    }
}