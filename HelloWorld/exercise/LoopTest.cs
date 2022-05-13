using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.exercise
{
    class LoopTest
    {
        //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

        public void exec1()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
                continue;

            }
            Console.WriteLine("todal number : " + count);

        }
        //2- Write a program and continuously ask the user to enter a number or "ok" to exit.Calculate the sum of all the previously entered numbers and display it on the console.

        public void exec2()
        {
            var output = 0;
            while (true)
            {
                
                Console.WriteLine("Enter a number or ennter OK to Quit :");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    output = output + Convert.ToInt32(input);
                    Console.WriteLine("Sum is : " + output);
                }
            }

        }

        //3- Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console.
        //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        public void exec3()
        {
            Console.WriteLine("Enter a number to find the factorial : ");

            var number = Convert.ToInt32(Console.ReadLine());
            var output = 1;
            while (number != 0)
            {
                output = output * number;
                number--;


            }
            Console.WriteLine("factorial is : " + output);
        }

        //4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
        //If the user guesses the number, display “You won"; otherwise, display “You lost".
        //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

        public void exec4()
        {
            var number = new Random().Next(1, 10);
            Console.WriteLine("Its a secret " + number);
            Console.WriteLine("I have picked a number try to guess them in four chances: ");
            var chances = 4;
            while (chances != 0)
            {
                Console.WriteLine("Enter the number to guess: ");
                var input = Convert.ToInt32( Console.ReadLine());
                if (input == number)
                {
                    Console.WriteLine("WoW u won!!!!");
                    break;
                }
                else
                {
                    chances--;
                    Console.WriteLine("its wrong guess again. remaining guesses : " + chances);
                    continue;
                }

            }

        }
        //5- Write a program and ask the user to enter a series of numbers separated by comma.
        //Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

        public void exec5()
        {
            Console.WriteLine("enter the number sepearetd by , " );
            var input = Console.ReadLine();
            var list = input.Split(',');

            var currentMax = list[0];

            foreach ( var i in list)
            {
                if ( Convert.ToInt32( i) > Convert.ToInt32( currentMax))
                {
                    currentMax = i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("maximum value is in for  " +  currentMax);

            var a = list.Max();
            Console.WriteLine("maximum value is " + a);

                
        }



    }
}
