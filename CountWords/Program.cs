using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào các chuỗi, nhập chuỗi trống để kết thúc: ");
            var list = new List<string>();
            var input = "learn java by example guide to advance java example of distributed in java";
            while (input != "")
            {
                list.Add(input);
                input = Console.ReadLine();
            }
            var result = new Dictionary<string, int>();
            foreach (var item in list)
            {
                var words = item.Split(' ');
                foreach (var word in words)
                {
                    if (result.ContainsKey(word))
                    {
                        result[word]++;
                    }
                    else
                    {
                        result.Add(word, 1);
                    }
                }
            }
            var total = 0;
            foreach (var item in result)
            {
                total += item.Value;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine($"Tổng số từ: {total}");
        }

    }
}
