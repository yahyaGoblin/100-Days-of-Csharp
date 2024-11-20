namespace Ans_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("First Number : " + a);
            Console.WriteLine("Second Number : " + b);

            Console.ReadLine();
        }
    }
}
