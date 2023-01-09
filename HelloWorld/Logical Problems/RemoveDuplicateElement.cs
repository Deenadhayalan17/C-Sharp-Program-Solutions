using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logical_Problems
{
    public partial class RemoveDuplicateElement
    {
        //C# Program to Remove Duplicate Elements from an Array
        public void Method1()
        {
            int i = 0, j = 0;

            int[] arr1 = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };

            for (i = 0; i < arr1.Length; i++)
            {
                for (j = 0; j < arr1.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (arr1[j] == arr1[i])
                    {
                        break;
                    }
                }
                if(arr1.Length== j)
                {
                    Console.Write(arr1[i]+" ");
                }
            }
        }
        //O(n2) to O(nlogn)
        public void Method2()
        {
            int[] arr1 = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };

            int length = arr1.Length;

            Array.Sort(arr1);

            if (arr1[0] != arr1[1])
            {
                Console.Write(arr1+ " ");
            }

            for (int i =1;i< length-1;i++) {

                if (arr1[i] != arr1[i-1] && arr1[i] != arr1[i + 1]) {
                    Console.Write(arr1[i] + " ");  
                }

            }
            if ( arr1[length - 1] != arr1[length - 2])
            {
                Console.Write(arr1[length - 1] + " ");

            }

        }
    }
}
