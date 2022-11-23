using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Design;

namespace HelloWorld.Logical_Problems
{
    public class Darrayfrom2d
    {
        public void Method1()
        {
            //  System.Console.WriteLine("Its working ");

            int[,] int2DArray = new int[2, 3];
            Console.Write("enter the 2d Array elements: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int2DArray[i, j] =
                        Convert.ToInt32(Console.ReadLine());
                }
            }
            int index = 0;

            int NoofRows = int2DArray.GetLength(0);

            int NoofColumns = int2DArray.GetLength(1);

            int[] oneDimenstionArray = new int[NoofRows * NoofColumns];


            for (int y = 0; y < NoofColumns; y++)
            {
                for (int x = 0; x < NoofRows; x++)
                {
                    oneDimenstionArray[index] = int2DArray[x, y];
                    index++;
                }
            }

            Console.WriteLine("1D Array Elements: ");

            foreach (int item in oneDimenstionArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();

        }
        Creating the 1D Array From 2D Array Row Wise in C#:
        public void Method2()
        {
            int[,] int2dArray = new int[2, 3];
            Console.WriteLine("enter the numbers");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int2dArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int index=0;
            int row = int2dArray.GetLength(0);
            int column =int2dArray.GetLength(1);
            int[] oneDimenstionArray = new int[row * column];

            for (int i =0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    oneDimenstionArray[index]= int2dArray[i, j];
                    index++;
                }
            }
            Console.WriteLine("the values are ");
            foreach(int i in oneDimenstionArray)
            {
                Console.WriteLine(i +" ");
            }


        }



    }

}
