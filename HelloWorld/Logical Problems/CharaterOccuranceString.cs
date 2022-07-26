using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld.Logical_Problems
{
    public class CharaterOccuranceString
    {
        public void Method1()
        {
            Console.WriteLine("Enter the String");

            string input = Console.ReadLine();

            input = input.Replace(" ", string.Empty);

            while (input.Length > 0)
            {
                Console.Write(input[0] + " : ");
                int count = 0;
                for (int j =0; j < input.Length; j++)
                {
                    if (input[0] == input[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
        }
        public void Method2()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char ch in input.Replace(" ", string.Empty)){
                if (dic.ContainsKey(ch))
                {
                    dic[ch] = dic[ch] + 1;

                }
                else
                {
                    dic.Add(ch, 1);
                }
            }

            foreach(var item in dic.Keys)
            {
                Console.WriteLine(item + " " + dic[item]);
            }
        }
        public void Method3()
        {
            Console.WriteLine("Enter the String: ");

            string message = Console.ReadLine();

            Dictionary<char, int> dict = message.Replace(" ", string.Empty)
                                        .GroupBy(c => c)
                                        .ToDictionary(gr => gr.Key, gr => gr.Count());
            foreach(var i in dict.Keys)
            {
                Console.WriteLine(i +" "+ dict[i]);
            }


        }



    }
}
