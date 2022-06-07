using System;

namespace HelloWorld.exercise
{
    public class ArmstrongNumber
    {

        public void Method1()
        {
            int i = 0;
            int count = 0;
            int[] Array = new int[10];
            double sum = 0;

            Console.WriteLine("Enter the Number to Check: ");
            int input = int.Parse(Console.ReadLine());

            int temp = input;

            while (input > 0)
            {
                Array[i++] = input % 10;
                input = input / 10;
                count++;

            }

            for (i = 0; i < count; i++)
            {
                sum += Math.Pow(Array[i], count);

            }
            if (sum == temp)
            {
                Console.WriteLine("Number is a amstrong number");
            }
            else
            {
                Console.WriteLine("It is not a amstrong Number");
            }


        }


    }


}
