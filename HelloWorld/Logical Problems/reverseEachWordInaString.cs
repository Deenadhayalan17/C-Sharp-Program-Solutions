using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Logical_Problems
{
    public class ReverseEachWordInaString
    {
        //Without using any built-in function
        public void Method1()
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            StringBuilder reverseString = new StringBuilder();
            List<char> charlist = new List<char>();
            
            for (int i=0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ' || i == inputString.Length - 1)
                {
                    if (i == inputString.Length - 1)
                    {
                        charlist.Add(inputString[i]);
                    }
                    for(int j = charlist.Count - 1; j >= 0; j--)
                    {
                        reverseString.Append(charlist[j]);
                    }
                    reverseString.Append(' ');
                    charlist.Clear();
                }
                else
                {
                    charlist.Add(inputString[i]);
                }
            }
            Console.WriteLine("the value is " + reverseString);

        }
        //Using Stack to Reverse Each Word in C#
        public void Method2()
        {
            Console.WriteLine("Enter the word:");

            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i=0; i < input.Length;i++)
            {
                if (input[i]!=' ')
                {
                    stack.Push(input[i]);
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        Console.Write(stack.Pop());

                    }
                    Console.Write(' ');
                }

            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());


            }
            Console.ReadKey();

        }

    }
}
