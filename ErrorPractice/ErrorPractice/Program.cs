using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ErrorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog";
            Console.WriteLine(SumOfIntegersInString(s));
        }

        public static int SumOfIntegersInString(string s)
        {
            return Regex.Matches(s, "\\d+").Sum(x => int.Parse(x.Value));
        }
    }
}
