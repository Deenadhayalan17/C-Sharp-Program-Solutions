namespace HelloWorld.exercise
{
    partial class Program
    {
        public class Swapping
        {
            //Swapping two numbers/string without third variable;

            //using add and sub
            public void Method1()
            {
                int a = 10;
                int b = 20;
                System.Console.WriteLine($"Number before swapping:a= {a} b ={b}");
                a = a + b;
                b = a - b;
                a = a - b;
                System.Console.WriteLine($"Number after swapping:a= {a} b ={b}");
            }
            // swap using mul and div
            public void Method2()
            {
                int a = 10;
                int b = 20;
                System.Console.WriteLine($"Number before swapping:a= {a} b ={b}");

                a = a * b;
                b = a / b;
                a = a / b;

                System.Console.WriteLine($"Number after  swapping:a= {a} b ={b}");
            }
            //string swap 
            public void Method3()
            {
                string a = "Hello";
                string b = "World";
                System.Console.WriteLine($"string before swapping:a= {a} b ={b}");
                a = a+b;
                b = a.Substring(0, b.Length);
                a = a.Substring(b.Length);
                System.Console.WriteLine($"string after swapping:a= {a} b ={b}");
            }

        }

    }
}
