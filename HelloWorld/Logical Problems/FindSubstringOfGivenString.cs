using System;
using System.Linq;
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
        //Finding Unique Substrings of a Given String in C#:

        public void Method3()
        {
            Console.WriteLine("Enter the string:");
            string Input = Console.ReadLine();

            int len = Input.Length;

            int temp = 0;

            string[] SubStringArray = new string[len * (len + 1) / 2];

            for (int i = 0; i < len; i++) { 
                for (int j = 0; j < len - i; j++)
                {
                    SubStringArray[temp] = Input.Substring(i, j + 1);
                    temp++;

                }
            }
            SubStringArray = SubStringArray.Distinct().ToArray();

            Console.WriteLine("All unique substring for strings are");

            for (int i =0; i < SubStringArray.Length; i++)
            {
                Console.Write(SubStringArray[i] + " ");
            }
            Console.ReadKey();
        }
        public void Method4()
        {
            Console.WriteLine("Enter String : ");

            string input = Console.ReadLine();

            var Substrings =

                from i in Enumerable.Range(0, input.Length)
                from j in Enumerable.Range(0, input.Length - i + 1)
                where j > 1
                select input.Substring(i, j);

            // 
            Console.WriteLine();
            Console.WriteLine("all sub strings are: ");

            foreach (string substring in Substrings)
            {

                Console.WriteLine(substring + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Enter all the unique string");


            foreach (string substring in Substrings.Distinct())
            {
                Console.Write(substring + " ");
            }
            Console.ReadKey();



        }


    }
}
