using System;

namespace HelloWorld.Logical_Problems
{
    public class RightCircularRotation
    {

        //10
        //20
        //30

        //30
        //10
        //20
        public void Method1()
        {

            Console.WriteLine("enter the values");
            int[] input = new int[5];
            for (int i =0;i<input.Length;i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i < input.Length - 1; i++)
            {
                temp = input[0];
                input[0] = input[i+1];
                input[i+1] = temp;

            }

            Console.WriteLine("the values are ");
            foreach(int i in input)
            {
                Console.WriteLine(i);
            }
        }
    }

}
