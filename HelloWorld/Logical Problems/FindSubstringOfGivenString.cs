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
        public void Method2()
        {

            for(int i =0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Method3()
        {

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
