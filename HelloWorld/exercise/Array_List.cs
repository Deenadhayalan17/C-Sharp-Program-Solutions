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
    }
}
