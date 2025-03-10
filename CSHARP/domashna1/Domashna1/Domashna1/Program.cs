namespace Domashna1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInput  = Console.ReadLine();
            double firstNumber = double.Parse(firstInput);
            Console.WriteLine("first number :" + firstNumber);

            string secondInput = Console.ReadLine();
            double secondNumber = double.Parse(secondInput);
            Console.WriteLine("second number:" + secondNumber);

            string thirdInput = Console.ReadLine();
            double thirdNumber = double.Parse(thirdInput);
            Console.WriteLine("thrid number:" + thirdNumber);

            double allNumbers = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine("average number is :" + allNumbers / 3);
            Console.ReadLine();

        }
    }
}
