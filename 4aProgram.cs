using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной
namespace Homework4a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);

            Console.ReadKey();
        }
    }
}
