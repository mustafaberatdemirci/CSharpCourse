namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //ForLoop2();
            //ForLoop3();

            //WhileLoop();
            //DoWhileLoop();

            //ForeachLoop();

            if(IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else 
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 30;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
            
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
            Console.WriteLine("-------------");
        }

        private static void ForLoop2()
        {
            for (int i = 1; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
            Console.WriteLine("-------------");
        }

        private static void ForLoop3()
        {
            for (int i = 50; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
            Console.WriteLine("-------------");
        }
    }
}