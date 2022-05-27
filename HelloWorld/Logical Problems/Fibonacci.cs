using System;

namespace HelloWorld.exercise
{
    public class Fibonacci
    {
        //iterative approachto print fibonacci series 

        public void Method1()
        {
            int firstnumber = 0, secondnumber = 1, nextnumber, input;

            Console.WriteLine("Enter the number:");
            input = int.Parse( Console.ReadLine());

            if (input < 2)
            {
                Console.Write("enter a number greater than 2");
            }
            else
            {
                Console.Write(firstnumber + " " + secondnumber + " ");

                for (var i =2; i < input; i++)
                {
                    nextnumber = firstnumber + secondnumber;
                    Console.Write(nextnumber + " ");
                    firstnumber = secondnumber;
                    secondnumber = nextnumber;

                }
            }
            Console.ReadKey();
        }
        //recurssive approach to print fibonacci series
        public void Method2()
        {
            int firstnumber = 0, secondnumber = 1, input;
            Console.WriteLine("Enter the number");
             input = int.Parse(Console.ReadLine());

            Fibonaccimethod(firstnumber, secondnumber, 1, input);

        }

        private void Fibonaccimethod(int firstnumber, int secondnumber, int counter, int input)
        {
            Console.Write(firstnumber + " ");
            if (counter < input)
            {
                Fibonaccimethod(secondnumber, firstnumber + secondnumber, counter + 1, input);
            }
        }
    }
}
