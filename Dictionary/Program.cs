using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static int Menu()
        {
            Console.WriteLine("Từ điển Anh - Việt");
            Console.WriteLine("1. Thêm từ mới");
            Console.WriteLine("2. Hiển thị toàn bộ ");
            Console.WriteLine("3. Tra từ");
            Console.WriteLine("4. Sửa từ");
            Console.WriteLine("5. Xóa từ");
            Console.WriteLine("6. Thoát");
            Console.WriteLine("Mời bạn chọn (1-6): ");
            var input = Console.ReadLine();
            return int.Parse(input);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var dictionary = new Dictionary<string, string>();
            var exit = false;
            while (!exit)
            {
                var menu = Menu();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Nhập từ tiếng Anh: ");
                        var en = Console.ReadLine();
                        Console.WriteLine("Nhập từ tiếng Việt: ");
                        var vn = Console.ReadLine();
                        if (dictionary.ContainsKey(en))
                        {
                            Console.WriteLine("Từ đã có trong từ điển");
                        }
                        else
                        {
                            dictionary.Add(en, vn);
                        }
                        break;
                    case 2:
                        foreach (var item in dictionary)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Nhập từ tiếng Anh: ");
                        var en1 = Console.ReadLine();
                        if (dictionary.ContainsKey(en1))
                        {
                            Console.WriteLine($"{en1} - {dictionary[en1]}");
                        }
                        else
                        {
                            Console.WriteLine("Từ không có trong từ điển");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhập từ tiếng Anh: ");
                        var en2 = Console.ReadLine();
                        Console.WriteLine("Nhập từ tiếng Việt: ");
                        var vn2 = Console.ReadLine();
                        if (dictionary.ContainsKey(en2))
                        {
                            dictionary[en2] = vn2;
                        }
                        else
                        {
                            Console.WriteLine("Từ không có trong từ điển");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Nhập từ tiếng Anh: ");
                        var en3 = Console.ReadLine();
                        if (dictionary.ContainsKey(en3))
                        {
                            dictionary.Remove(en3);
                        }
                        else
                        {
                            Console.WriteLine("Từ không có trong từ điển");
                        }
                        break;
                    case 6:
                        exit = true;
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
