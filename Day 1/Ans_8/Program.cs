namespace Ans_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square of a Number");

            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            int square = a * a;

            Console.WriteLine("Square of " + a + " is " + square);
            Console.ReadLine();
        }
    }
}
