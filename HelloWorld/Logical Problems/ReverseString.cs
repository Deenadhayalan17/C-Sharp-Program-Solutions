using System;

namespace HelloWorld.Logical_Problems
{
    public class ReverseString {

        //Reverse a String in C# without using Built-in metho
        public void Method1()
        {
            Console.WriteLine("Enter the string : ");
            string input = Console.ReadLine();
            string output = string.Empty;

            for(int i = input.Length -1 ; i>=0;i--)
            {
                output += input[i];
            }
            Console.WriteLine(output);
        }

        //Using the for-each loop to reverse a string in C#
        public void Method2()
        {
            Console.WriteLine("Enter the string: ");
            string input = Console.ReadLine();
            string output = string.Empty;

            foreach(char i in input)
            {
                output = i + output;
            }
            Console.WriteLine($"the value is :{output}");

        }
    }
}
