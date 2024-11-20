namespace Ans_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Arithmatic Operations");

            Console.WriteLine("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;

            Console.WriteLine("Sum of " + a + " and " + b + " is " + sum);
            Console.WriteLine("Subtraction of " + a + " and " + b + " is " + sub);
            Console.WriteLine("Multiplication of " + a + " and " + b + " is " + mul);
            Console.WriteLine("Division of " + a + " and " + b + " is " + div);

            Console.ReadLine();
        }
    }
}
