using System;

namespace HelloWorld.Logical_Problems
{

        public class DuckNumber
        {

            public void Method1()
            {
                Console.WriteLine("enter a number to check :");

                int number = Convert.ToInt32(Console.ReadLine());
                string str = number.ToString();

                int l = str.Length;

                int count = 0;

                for (int i =1; i < l; i++)
                {
                    char c = str[i];
                    if (c == '0')
                    {
                        count++;
                        break;
                    }
                }
                char f = str[0];

                if(count>0 &&(f=='0'|| f != '0'))
                {
                    Console.WriteLine("yes its a duck number");
                }
                else
                {
                    Console.WriteLine("its not a duck number");
                }

            }


        
    }
}
