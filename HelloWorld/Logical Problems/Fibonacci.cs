﻿using System;

namespace HelloWorld.exercise
{
    public class Fibonacci
    {
        //iterative approachto print fibonacci series 

        public void Method1()
        {
            int firstnumber = 0, secondnumber = 1, nextnumber, input;

            Console.WriteLine("Enter the number:");
            input = int.Parse(Console.ReadLine());

            if (input < 2)
            {
                Console.Write("enter a number greater than 2");
            }
            else
            {
                Console.Write(firstnumber + " " + secondnumber + " ");

                for (var i = 2; i < input; i++)
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
        //find the number in the series recurssion
        public void Method3()
        {
            int input;
            Console.WriteLine("enter the number you want in the series");
            input = int.Parse(Console.ReadLine());
            input = input - 1;
            Console.Write(nthfibnumber(input));
            Console.Read();
        }

        private int nthfibnumber(int input)
        {
            if (input == 0 || input == 1)
            {
                return input;
            }
            else
            {
                return (nthfibnumber(input - 1) + nthfibnumber(input - 2));
            }
        }
        //Without Using Recursive Function:

        public void Method4()
        {
            Console.WriteLine("enter a number ");
            int input = int.Parse(Console.ReadLine());

            input = input - 1;
            Console.WriteLine(fibnonrecussive(input));
        }

        private int fibnonrecussive(int input)
        {
            int firstnumber = 0, secondnumber = 1, nextnumber;
            if (input == 0)
            {
                return firstnumber;
            }
            for(int i = 2; i<=input;i++)
            {
                nextnumber = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = nextnumber;
            }
            return secondnumber;

        }
        //Print the Fibonacci Series up to a given number in C#?

        public int Method5()
        {
            Console.WriteLine("enter a number till series should be displayed");
            int input = int.Parse(Console.ReadLine());
            int firstnumber=0,secondnumber=1, nextnumber=1;
            Console.Write(firstnumber+" "+secondnumber+" ");

            while (nextnumber < input)
            {
                nextnumber = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = nextnumber;
                Console.Write(nextnumber+" ");
            }
            return firstnumber;
        }
    }
}
