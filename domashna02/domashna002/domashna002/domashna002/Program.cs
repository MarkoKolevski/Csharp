namespace domashna002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            string[] studentsH2 = new string[5];
            string[] studentsH3 = new string[5];

            for (int i = 0; i < studentsH2.Length; i++)
            {
                Console.WriteLine("enter name number" + (i + 1) + "for the First array:");
                studentsH2[i] = Console.ReadLine();
            }

            for (int i = 0; i < studentsH3.Length; i++)
            {
                Console.WriteLine("enter name number" + (i + 1) + "for the Second array:");
                studentsH3[i] = Console.ReadLine();
            }

            string input = default;
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.WriteLine("enter number between 1 and 2:");
                input = Console.ReadLine();
                if (input == "1" || input == "2")
                {
                    break;
                }
                Console.WriteLine("invalid number.Please enter 1 or 2");
            }
            if (input == "1")
            {
                for (int i = 0; i < studentsH2.Length; i++)
                {
                    Console.WriteLine("students in group H2:" + studentsH2[i] + " ");
                }
            }
            else if (input == "2")
            {
                for (int i = 0; i < studentsH3.Length; i++)
                {
                    Console.WriteLine("students in group H3: " + studentsH3[i] + " ");

                }
            }
        }
    }
}
