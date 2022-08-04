using System;
using System.Linq;

namespace HelloWorld.Logical_Problems
{
    public class RemoveDuplicateCharater
    {
        public void method1()
        {
            Console.WriteLine("Enter the string to remove duplicate:");
            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (!output.Contains(input[i]))
                {
                    output += input[i];
                }
            }
            Console.WriteLine("String is " + output);
            Console.ReadKey();

        }
        public void method2()
        {
            Console.WriteLine("Enter the string: ");
            //string 
        }

    }
}
