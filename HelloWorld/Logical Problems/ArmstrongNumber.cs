using System;

namespace HelloWorld.exercise
{
    public class ArmstrongNumber
    {
        //check wheter its a armstrong Number
        public void Method1()
        {
            int i = 0;
            int count = 0;
            int[] Array = new int[10];
            double sum = 0;

            Console.WriteLine("Enter the Number to Check: ");
            int input = int.Parse(Console.ReadLine());

            int temp = input;

            while (input > 0)
            {
                Array[i++] = input % 10;
                input = input / 10;
                count++;

            }

            for (i = 0; i < count; i++)
            {
                sum += Math.Pow(Array[i], count);

            }
            if (sum == temp)
            {
                Console.WriteLine("Number is a amstrong number");
            }
            else
            {
                Console.WriteLine("It is not a amstrong Number");
            }


        }
        //find the Armstring numbers in the range 
        public void Method2()
        {
            Console.WriteLine("Enter the start number");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end number");
            int End = int.Parse(Console.ReadLine());

            for (int i= start; i < End; i++)
            {
                 if (Amstrongfunction(i))
                {
                    Console.WriteLine(i);

                }
            }


        }

        private bool Amstrongfunction(int i)
        {
            int sum = 0;
            int Temporary = i;
            int length = i.ToString().Length;
            int temp = 0;

            while (i > 0)
            {
                temp = i % 10;
                i = i / 10;
                sum +=(int) Math.Pow(temp, length);

            }
            if(sum== Temporary)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }
    }


}
