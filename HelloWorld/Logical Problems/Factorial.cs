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

    }


}
