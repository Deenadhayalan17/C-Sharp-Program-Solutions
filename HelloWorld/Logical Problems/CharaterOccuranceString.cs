using System;

namespace HelloWorld.Logical_Problems
{
    public class CharaterOccuranceString
    {
        public void Method1()
        {
            Console.WriteLine("Enter the String");

            string input = Console.ReadLine();

            input = input.Replace(" ", string.Empty);

            while (input.Length > 0)
            {
                Console.Write(input[0] + " : ");
                int count = 0;
                for (int j =0; j < input.Length; j++)
                {
                    if (input[0] == input[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
        }


    }
}
