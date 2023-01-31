using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logical_Problems
{
    public class DisariumNumber
    {
        public void Method1()
        {
            Console.WriteLine("enter the number to check");
            int input = int.Parse(Console.ReadLine());
            string inputstr = input.ToString();
            int lenght = inputstr.Length;

            int last = 0, sum = 0, copy = input;
            while (copy > 0)
            {
                last = copy % 10;
                sum = sum + (int)Math.Pow(last, lenght);
                lenght--;
                copy = copy / 10;
            }
            if (sum == input)
            {
                Console.WriteLine("the given number is disarium");
            }
            else
            {
                Console.WriteLine("the given number is not a disarium");
            }
        }
        //Program to print all Disarium numbers between 1 and 100
        public void Method2()
        {
            int result = 0;
            Console.WriteLine("the numbers are");

            for (int i = 1; i <= 100; i++)
            {
                result = SumOfDigit(i);
                if (result == i)
                {
                    Console.Write(result + " ");
                }
            }

        }
        public int SumOfDigit(int digit)
        {
            int sum = 0, rem = 0;
            int len = CalculateLength(digit);
            while (digit > 0)
            {
                rem = digit % 10;
                sum=sum+(int) Math.Pow(rem, len);
                digit = digit / 10;
                len--;
            }
            return sum;
        }
        public int CalculateLength(int digit)
        {
            {
                int length = 0;
                while (digit != 0)
                {
                    length = length + 1;
                    digit = digit / 10;
                }
                return length;
            }
        }
    }
}
