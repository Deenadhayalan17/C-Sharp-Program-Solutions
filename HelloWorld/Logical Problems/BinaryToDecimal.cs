using System;

namespace HelloWorld.Logical_Problems
{
    public class BinaryToDecimal
    {
        public void Method1()
        {
            Console.WriteLine("Enter the Number:");
            int input = int.Parse(Console.ReadLine());

            int factor = 1;
            int output = 1;
            while (input > 0)
            {
                int val = input % 10;
                input = input / 10;
                output = factor * val;
                factor = factor * 2;


            }
            Console.WriteLine("the number is {0}",output);
        }
        public void Method2()
        {
            Console.WriteLine("Enter the binary");
            var input = int.Parse(Console.ReadLine());
            int output = Convert.ToInt32(input.ToString(), 2);
            Console.WriteLine($"the value is {output}");

        }

    }
}
