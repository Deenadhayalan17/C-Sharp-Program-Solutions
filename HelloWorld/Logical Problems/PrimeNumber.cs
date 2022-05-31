using System;

namespace HelloWorld.exercise
{
    public class PrimeNumber
    {

        public void Method1()
        {
            Console.WriteLine("Enter a number to check Prime or not :");

            int intput = int.Parse(Console.ReadLine());
            bool output = true;
            for (int i=2;i<=(intput/2);i++)
            {
                if (intput % i == 0)
                {
                    output = false;
                    break;
                }
                continue;

            }
            Console.WriteLine(output);

        }
        public void Method2()
        {
            Console.WriteLine("ENter the first number :");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ENter the second number :");
            int secondnumber= int.Parse(Console.ReadLine());

            for (int i = firstnumber; i < secondnumber; i++)
            {
                int counter = 0;
                for (int j =2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }

                }
                if (counter==0 && i != 1)
                {
                    Console.WriteLine("{0}",i);
                }
            }

        }
    }
    

}
