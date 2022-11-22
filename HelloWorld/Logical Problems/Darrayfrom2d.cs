using System;
using System.Drawing.Design;

namespace HelloWorld.Logical_Problems
{
    public class Darrayfrom2d{
        public void Method1()
        {
            //  System.Console.WriteLine("Its working ");

            int[,] int2DArray = new int[2, 3];
            Console.Write("enter the 2d Array elements: ");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int2DArray[i, j] =
                        Convert.ToInt32(Console.ReadLine());
                }
            }
            int index = 0;

            int NoofRows = int2DArray.GetLength(0);

            int NoofColumns= int2DArray.GetLength(1);

            int[] oneDimenstionArray = new int[NoofRows*NoofColumns];


            for(int y = 0; y < NoofColumns; y++)
            {
                for(int x = 0; x < NoofRows; x++)
                {
                    oneDimenstionArray[index] = int2DArray[x, y];
                    index++;
                }
            }

            Console.WriteLine("1D Array Elements: ");

            foreach(int item in oneDimenstionArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();

        }
       
        

    }
    
}
