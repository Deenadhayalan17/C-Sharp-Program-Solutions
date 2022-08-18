using System;
using System.Text;

namespace HelloWorld.Logical_Problems
{
    public class FindSubstringOfGivenString
    {
        public void Method1()
        {
            Console.WriteLine("Enter the string to get: ");

            string input = Console.ReadLine();
            Console.WriteLine("the substrings are : ");
            for (int i = 0; i < input.Length; ++i)
            {
                StringBuilder substring  = new StringBuilder(input.Length - i);
                for(int j = i; j < input.Length; ++j)
                {
                    substring.Append(input[j]);
                    Console.WriteLine(substring+" ");
                }

            }
            Console.ReadKey();

        }
        //Using Substring method:
        public void Method2()
        {
            Console.WriteLine("Enter the string : ");

            string inputString = Console.ReadLine();

            int len = inputString.Length;
            Console.WriteLine("All subString for the given string are ");

            for (int i =0; i < len; i++)
            {
                for (int j=0; j < len - i; j++)
                {
                    Console.WriteLine(inputString.Substring(i,j+1)+" ");
                }
            }
            Console.ReadKey();

        }
       
    }
}
