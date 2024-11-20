namespace Alt_Ans_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any type of data:");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int intValue))
            {
                Console.WriteLine("Data type: int");
            }
            else if (double.TryParse(input, out double doubleValue))
            {
                Console.WriteLine("Data type: double");
            }
            else if (bool.TryParse(input, out bool boolValue))
            {
                Console.WriteLine("Data type: bool");
            }
            else if (char.TryParse(input, out char charValue) && input.Length == 1)
            {
                Console.WriteLine("Data type: char");
            }
            else
            {
                Console.WriteLine("Data type: string");
            }

            Console.ReadLine();
        }
    }
}