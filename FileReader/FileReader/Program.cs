using System;
using System.Collections.Generic;
using System.Linq;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> hash = new Dictionary<string, int>();
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\Titan\source\repos\FileReader\FileReader\text.txt");
            
            //Adds each word to hash map and adds the amount of times used
            foreach (string paragraph in text)
            {
                string[] words = paragraph.Split(" ");
                foreach (string word in words) {
                    if (hash.ContainsKey(word))
                    {
                       int count = hash.GetValueOrDefault(word);
                        hash[word] = count+1;
                    }
                    else {
                        hash.Add(word, 1);
                    }
                }
            }

            foreach (KeyValuePair<string, int> word in hash.OrderBy(i => i.Key)){
                Console.WriteLine("word: " + word.Key + " key: " + word.Value);
            }

        }
    }
}
