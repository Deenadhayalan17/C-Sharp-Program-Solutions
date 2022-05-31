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
        public void Method2()
        {

        }
    }
    

}
