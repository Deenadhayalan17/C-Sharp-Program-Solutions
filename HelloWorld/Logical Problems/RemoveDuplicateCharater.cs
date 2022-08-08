using System;
using System.Collections.Generic;
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
        //Using HashSet to Remove Duplicate Characters:
        public void method2()
        {
            Console.WriteLine("Enter the string: ");
            //string 
            string input = Console.ReadLine();
            string output = string.Empty;

            var unique = new HashSet<char>(input);


            foreach (char i in unique)
            {
                output += i;
            }

            Console.WriteLine("The Number is " + output);
        }
        //Using LINQ to Remove Duplicate Characters From a String:

        public void method3()
        {
            Console.WriteLine("ENter the strign to reverse.");

            string Input = Console.ReadLine();
            var Processed = Input.ToCharArray().Distinct().ToArray();
            string output = new string(Processed);

            Console.WriteLine("The value is "+ output);

        }

    }
}
