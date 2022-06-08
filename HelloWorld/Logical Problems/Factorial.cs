using System;

namespace HelloWorld.exercise
{
    public class Factorial
    {
        //Factorial Number Program in C# using for loop:

        public void Method1()
        {
            Console.WriteLine("Enter a number to find the Factorial: ");

            int input = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i=1;i<=input;i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"The factorial is {factorial}");
        }
        //while loop 
        public void Method2()
        {
            Console.WriteLine("Enter a number to find the factorial: ");

            int input = int.Parse(Console.ReadLine());
            int output = 1;
            while (input > 0)
            {
                output = output * input;
                input--;
            }
            Console.WriteLine($"the factorial is {output}");

        }
        //Factorial of a number using Recursive Function in C#
        public void Method3()
        {
            Console.WriteLine("Enter the number to find the factorial: ");

            int input = int.Parse(Console.ReadLine());

            int Output = FacRecMethod(input);
            Console.WriteLine("factorial is " + Output);

        }

        private int FacRecMethod(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else
            {
                return input * FacRecMethod(input - 1);
            }
        }
        //do while
        public void Method4()
        {
            Console.WriteLine("Enter a number to find Factorial:");

            int input = int.Parse(Console.ReadLine());

            int factorial = 1;
            do
            {
                factorial = factorial * input;
                input -- ;

            }
            while (input != 0);

            Console.WriteLine($"The Factorial is {factorial}");

        }
    }


}
