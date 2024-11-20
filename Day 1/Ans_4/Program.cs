namespace Ans_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of Two Numbers");

            Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine("Sum of " + a + " and " + b + " is " + sum);

            Console.ReadLine();
        }
    }
}
