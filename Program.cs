using System;

namespace 字符串转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "123---89---7--5685--9";
           string[] s1= s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
           string s2= string.Join("-", s1);
            Console.WriteLine(s2);
        }
    }
}
