using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logical_Problems
{
    class SumDigit
    {
        public void Method1()
        {
            Console.WriteLine("Enter the Number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, reminder;

            while (number > 0)
            {
                reminder = number% 10;
                sum = sum + reminder;
                number = number / 10;

            }
            Console.WriteLine($"The Sun of Digit is :{sum}");
            Console.ReadKey();
        }

        //Finding the sum of digits of a number using Recursion in C#:
        public void Method2()
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = SumOfDigit(number);
            Console.WriteLine($"The Sun of Digit is :{sum}");

        }

        private int SumOfDigit(int number)
        {
            if (number != 0)
            {
                return (number % 10 + SumOfDigit(number / 10));
            }
            else
            {
                return 0;
            }
        }

        //Using Linq to find the sum of digits of a number in C#:

        public void Method3()
        {
            Console.WriteLine("Enter the number : ");

            int number = int.Parse(Console.ReadLine());

            int sum = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();

            Console.WriteLine($"The Sum of Digit is : {sum}");
        }
    }
}
