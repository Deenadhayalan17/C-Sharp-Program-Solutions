using System;

namespace HelloWorld.Logical_Problems
{
    public class DecimalToBinary
        {

        public void Method1()
        {
            Console.WriteLine("Enter the number which you wana convert into binary:");

            int input = int.Parse(Console.ReadLine());
            var Arr = new int[10];
            int i;// global so that we can use tha in reverse
            for ( i = 0; input > 0; i++)
            {
                Arr[i] = input % 2;
                input = input / 2;
            }

            Console.WriteLine("Binary representation of the given number is : ");
            for ( i = i-1; i >= 0; i--)
            {
                Console.Write(Arr[i]);
            }
        }
        public void Method2()
        {
            Console.WriteLine("Enter a number");

            int input = int.Parse(Console.ReadLine());
            string Output = string.Empty;
            for (int i = 0; input > 0; i++)
            {
                Output = input % 2 + Output;
                input = input / 2;
            }
            Console.WriteLine($"the number is :{Output}");

            


            
        }




        }
    
}
