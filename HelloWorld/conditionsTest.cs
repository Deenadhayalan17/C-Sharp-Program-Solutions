using System;

namespace HelloWorld
{
    class conditionsTest
    {
        //1- Write a program and ask the user to enter a number.The number should be between 1 to 10.
        //If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
        //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
        public void exex1()
        {
            System.Console.WriteLine("Enter as number:");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number>0 && number < 10)
            {
                Console.WriteLine("its valid");
            }
            else
            {
                Console.WriteLine("its invalid");
            }
        }
        //2- Write a program which takes two numbers from the console and displays the maximum of the two.
        public void exex2()
        {
            Console.WriteLine("Enter two numbers:");
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Convert.ToInt32(a);
            var d = Convert.ToInt32(b);

            if (c >d )
            {
                Console.WriteLine(c + " Greater than " + d);
            }
            else if (c == d)
            {
                Console.WriteLine(c + " is equal too " + d);

            }
            else
            {
                Console.WriteLine(d + " Greater than " + c);

            }
        }
        //3- Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.
        public enum orientation
        {
            landscape,
            potrait
        }
        public void exex3()
        {
            Console.WriteLine("enter the width:");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the height:");
            var height = Convert.ToInt32(Console.ReadLine());
            var result = (width > height) ? orientation.landscape : orientation.potrait;
            Console.WriteLine("it is a :" + result);


        }

        //4- Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera,
        //sensors, etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.Once set,
        //the program asks for the speed of a car.If the user enters a value less than the speed limit, program should display
        //Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit points.
        //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of
        //demerit points is above 12, the program should display License Suspended.
        public void exec4()
        {
            Console.WriteLine("Enter the speed limit :");
            var SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed  :");
            var ActualSpeed = Convert.ToInt32(Console.ReadLine());
            if (ActualSpeed < SpeedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var a = ActualSpeed - SpeedLimit;
                var b = a / 5;
                if (b > 12)
                {
                    Console.WriteLine("License Expired");
                }
                else
                    Console.WriteLine("Demerit points: " + b);
            }


        }

    }

}
