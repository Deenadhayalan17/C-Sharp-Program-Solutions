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
            string inputstr= input.ToString();
            int lenght = inputstr.Length;

            int last = 0, sum = 0, copy = input;
            while(copy> 0)
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
    }
}
