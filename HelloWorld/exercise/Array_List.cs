using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.exercise
{
    class Array_List
    {

        //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name).
        //Depending on the number of names provided, display a message based on the above pattern.
        public void exec1()
        {
            List<string> deena = new List<string> { };

            while (true)
            {

                Console.WriteLine("Enter the name: ");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name) ) {
                    break;

                }
                else
                {
                    deena.Add(name);
                }
            }
            if (deena.Count == 1)
            {
                Console.WriteLine(deena[0]+" Liked your photo");
            }
            else if (deena.Count == 2)
            {
                Console.WriteLine(deena[0] + " And "  +deena[1] +" Liked your photo");

            }
            else if (deena.Count > 2)
            {
                Console.WriteLine(deena[0] + ' ' + deena[1] + " And"+  Convert.ToString( deena.Count -2) +"others Liked your photo");
            }
        }

        //2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

        public void exec2()
        {
            Console.WriteLine("Enter the Name");
            var input = Console.ReadLine();
            var mass = new char[input.Length];
            for (var i =0; i < input.Length ; i++){
                mass[i] = input[i];
            }
            //for (var i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            Array.Reverse(mass);
            var output = new string(mass);
            Console.WriteLine(output);


        }

        //3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered,
        //display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers,
        //sort them and display the result on the console.

        public void exec3()
        {
            List<int> mass = new List<int>() { };
            while (mass.Count < 5)
            {
                Console.WriteLine("Enter 5 unique number");
                var number = Convert.ToInt32(Console.ReadLine());
                if (mass.Contains(number))
                {
                    Console.WriteLine("enter a unique number ");
                }
                else
                {
                    mass.Add(number);
                    foreach (var i in mass)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        public void exec4()
        {
            List<int> list = new List<int>() { };
            while (true)
            {
                Console.WriteLine("enter the number:");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    list.Add(Convert.ToInt32(input));
                    continue;

                }
            }
            var unique = new List<int>() ;
            foreach ( int i in list)
            {
                if (!unique.Contains(i))
                {
                    unique.Add(i);
                }
            }
            foreach(var  i in unique)
            {
                Console.WriteLine(i);

            }
        }
        //5- Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise,
        //display the 3 smallest numbers in the list.
        public void exec5()
        {
            Console.WriteLine( "enter comma seperated values: ");
            var input = Console.ReadLine();
            var list = input.Split(',');
            if (list.Count() < 5)
            {
                //list.DefaultIfEmpty();
                Console.WriteLine("invalid List");
            }
            else
            {
                var smallestList = new List<int>();
                while(smallestList.Count < 3)
                {
                    var min = smallestList[0];
                    //foreach (int a in list)
                    //{
                    //    if ( a < min)
                    //    {

                    //    }
                    //}
                }
            }


        }


    }
}
