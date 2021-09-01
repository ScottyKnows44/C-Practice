using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace ErrorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog";
            SumOfIntegersInString(s);
        IsPalindrome(44333344);
            IsIsogram("Consecutive");
        }

        public static int SumOfIntegersInString(string s)
        {
            return Regex.Matches(s, "\\d+").Sum(x => int.Parse(x.Value));
        }
        public static bool IsPalindrome(int num)
        {
            string reverse = string.Concat(num.ToString().Reverse());

            return num.ToString() == reverse;
        }

        public static bool IsIsogram(string str)
        {
            char[] array = str.ToLower().ToCharArray();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach(char x in array) {
                Console.WriteLine(x);
                if(map.ContainsKey(x)) {
                    return false;
                }
                map.Add(x, 1);
            }
            return true;
        }
    }
}
