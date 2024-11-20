namespace Ans_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine data type of variable");

            int a = 10;
            double b = 20.5;
            string c = "Hello";
            bool d = true;
            char e = 'A';

            System.Console.WriteLine("Data type of a: " + a.GetType());
            System.Console.WriteLine("Data type of b: " + b.GetType());
            System.Console.WriteLine("Data type of c: " + c.GetType());
            System.Console.WriteLine("Data type of d: " + d.GetType());
            System.Console.WriteLine("Data type of e: " + e.GetType());

            Console.ReadLine();
        }
    }
}
