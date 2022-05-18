using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.exercise
{
    class stringBuilder
    {
        

        //1- Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
        //display a message: "Consecutive"; otherwise, display "Not Consecutive".

        public void exec1()
        {
            Console.WriteLine("Enter the line seperated by comma's");
            var listnum = new List<int>();
             var input = Convert.ToString( Console.ReadLine());
            //var stingBuilder = new stringBuilder();
            string[] list = input.Split('-');
            foreach (var i  in list)
            {
                listnum.Add(Convert.ToInt32(i));
            }
            bool flag = true;
            listnum.Sort();
             for(var i =1; i <= listnum.Count - 1; i++)
            {
                if (listnum[i] != listnum[i - 1] +1)
                {
                    flag = false;

                    break;
                }
            }

            var message = flag ? "concecutive" : "nonconcecutive";
            Console.WriteLine(message);


        }
        //2- Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter,
        //without supplying an input, exit immediately; otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.

        public void exec2()
        {
            var aftersplit = new List<int>();
            Console.WriteLine("enter number seperated by - ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Environment.Exit(0);

            }
            //else
            //{
            //     aftersplit = Convert.ToInt32( input.Split('-'));

            //}
            foreach (var i in input.Split('-') )
            {
                aftersplit.Add(Convert.ToInt32(i));
            }

            bool flag = false;
            var newlist = new List<int>();

            foreach (int i in aftersplit)
            {
                if (!newlist.Contains(i))
                {
                    newlist.Add(i);
                }
                else
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("duplicate value is present;");
            }

        }


//3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00).
//A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
         public void exec3()
        {
            Console.WriteLine("ENTER THE TIME");
            var input = Console.ReadLine();
            var list = new List<int>();
            foreach (var i in input.Split(':'))
            {
                list.Add(Convert.ToInt32( i));

            }
            if(list[0]>=00 && list[0] <= 23 && 00<=list[1]&& list[1] <= 59 )
            {
                Console.WriteLine("OK");

            }
            else
            {
                Console.WriteLine("Invalid date ");
            }


        }
//4- Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.For example,
//if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input.So,
//if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        public void exec4()
        {
            Console.WriteLine("enter the string");
            var input = Console.ReadLine();
            var output = "";
            foreach (var i in input.Split(' '))
            {
                output += char.ToUpper(  i[0]) + i.ToLower().Substring(1);
                
            }
            Console.WriteLine(output);
        }
//5- Write a program and ask the user to enter an English word.Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

        public void exec5()
        {
            Console.WriteLine( "Enter the word");
            var input = Console.ReadLine();
            int count = 0 ;
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u'});
            foreach(var i in input)
            {
                if (vowels.Contains(i))
                {
                    count += 1;
                }


            }
            Console.WriteLine("the count of vowles is : " + count);
        }




    }
}
