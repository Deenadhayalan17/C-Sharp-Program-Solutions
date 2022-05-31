using System;

namespace HelloWorld.exercise
{
    public class ReverseDigits
    {
        //reverse a given number in C#
        public void Method1()
        {
            Console.WriteLine("Enter the number to reverse:");
            int input = int.Parse(Console.ReadLine());

            int reminder, sum = 0;

            while (input > 0)
            {
                reminder = input % 10;
                sum = sum * 10 + reminder;
                input = input / 10;

            }
            Console.WriteLine("reverse of the digit is : " + sum);
            
        }
        //reverse sting in array method
        public void Method2()
        {
            Console.WriteLine("Enter a text");

            string input = Console.ReadLine();

            char[] inputarray = input.ToCharArray();
            Array.Reverse(inputarray);

            string output = new string(inputarray);

            Console.WriteLine(output);

        }
        // reverse sting in For Loop
    }


}
