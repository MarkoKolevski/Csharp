namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string firstInput = Console.ReadLine();
            int firstNumber = int.Parse(firstInput);
            Console.WriteLine(firstNumber);

            string secondInput = Console.ReadLine();
            int secondNumber = int.Parse(secondInput);
            Console.WriteLine(secondNumber);

            string thirdInput = Console.ReadLine();
            Console.WriteLine(thirdInput);


            if (thirdInput == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            else if (thirdInput == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            else if (thirdInput == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else if (thirdInput == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            Console.ReadLine();

        }
    }
}
