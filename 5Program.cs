using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организовать в центре экрана.

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Алина Брам, Витебск";
            var width = Console.WindowWidth;
            var padding = width / 2 + text.Length / 2;
            Console.WriteLine("{0," + padding + "}", text);

            Console.ReadKey();
        }
    }
}
