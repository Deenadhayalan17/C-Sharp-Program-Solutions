using System;

namespace HelloWorld.Logical_Problems
{
    public class ODinto2D
    {
        public void Method1()
        {
            Console.WriteLine("enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the number of columns:");
            int column = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the one d array:");
            int[] onedArray = new int[rows*column];

            for (int i = 0; i < onedArray.Length; i++)
            {
                onedArray[i]=int.Parse(Console.ReadLine());
                
            }
            int index = 0;
            int[,] TDArray= new int[rows,column];

            for (int i=0;i<rows;i++)
            {
                for(int j = 0; j < column; j++)
                {
                    TDArray[i, j] = onedArray[index];
                    index++;
                }
            }
            Console.WriteLine("the 2 d array is ");
            foreach(int i in TDArray)
            {
                Console.WriteLine(i + " ");
            }

        }
    }

}
