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
        }
    }
}
