using NorthcodersMyFirstLibrary;
using NorthcodersEvaluateNums;
using System.Diagnostics.CodeAnalysis;

namespace NorthcodersMyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            int age = Int32.Parse(args[1]);
            string favouriteFilm = args[2];

            Console.WriteLine("Hello, my name is: " + name);
            Console.WriteLine("My age is: " + age);
            Console.WriteLine("My favourite film is: " + favouriteFilm);

            NorthcodersMyFirstLibrary.Class1.Hello();

            int sum = NorthcodersEvaluateNums.Class1.SumNums(3, 4);
            Console.WriteLine("Sum of 3 and 4 is: " + sum);
        }
    }
}
