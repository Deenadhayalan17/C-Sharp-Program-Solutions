using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Logical_Problems
{
    internal class AngleBtwHrandMinuteHand
    {
        public void Method1()
        {
            Console.WriteLine("enter the hr :");
            int hr = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the minute hand:");
            int min = int.Parse(Console.ReadLine());

            int hrangle = (hr*30)+(min*30/60);

            int minangle = min * 6;

            int diff = Math.Abs(hrangle - minangle);

            if(diff > 180) {
                diff = diff - 180;
            }
            Console.WriteLine("the angle btw them is :"+ diff);

        }
    }
}
