using System;

namespace HelloWorld.exercise
{
    public class Palindrome
    {
        //integer palindrome using reminder 
        public void Method1()
        {
            Console.WriteLine("Enter the number to check palindrome or not:");

            int input = int.Parse(Console.ReadLine()) ;

            int sum = 0, reminder;
            int temp = input;
            while (input > 0)
            {
                reminder = input % 10;
                sum = (sum * 10) + reminder;
                input = input / 10;

            }
            if (temp==sum)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }



        }
        //given string is Palindrome or not
        public void Method2()
        {
            Console.WriteLine("Enter teh sting we have to check:");

            string input = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];

            }
            if (input == reverse)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("it is not a palindrome;");
                
            }



        }

        //Using the for-each loop:
        public void Method3()
        {
            Console.WriteLine("Enter the name to check :");

        }
    }


}
