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

    }
}
