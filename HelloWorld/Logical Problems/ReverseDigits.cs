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
        public void Method3()
        {

            Console.WriteLine("ENTER THE string");
            string input = Console.ReadLine();

            string output = string.Empty;

            foreach(char i in input)
            {
                output = i + output;
            }
            Console.WriteLine(output);

        }
        // reverse loop Concept
        public void Method4()
        {
            Console.WriteLine("Enter the string need to reverse:");
            string input = Console.ReadLine();

            string output = string.Empty;

            for (int i = input.Length-1; i >= 0; i--)
            {
                output = output + input[i];
            }
            Console.WriteLine(output);
        }

    }


}
