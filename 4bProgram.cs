using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать программу обмена значениями двух переменных:
//б) *без использования третьей переменной.
namespace Homework4b
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 4;

            a = - a - b;
            b = - a - b;
            a = - a - b;

            Console.WriteLine("a = "+a+" b = "+b);

            Console.ReadKey();
        }
    }
}
