using System;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            Console.WriteLine("Enter the String for Addition");
            String Str = Console.ReadLine();
           // Console.WriteLine("{0}", Str);
            char[] seperator = { '+' };
            string[] str1 = Str.Split(seperator);
         
            foreach (string s in str1)
            {
                //Console.WriteLine("the values we enetered are {0}\n ", s);
                if (s.All(char.IsDigit))
               value = value + int.Parse(s);
            }
            Console.WriteLine("The value is {0}", value);

        }
    }

}
