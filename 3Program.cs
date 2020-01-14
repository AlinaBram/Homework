using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, 
//y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
//используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
namespace Homework3b
{
    class Program
    {
        static void Distance()
        {
            
            Console.WriteLine("Введите координаты x1, y1");
            float x1 = Convert.ToSingle(Console.ReadLine());
            float y1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите координаты x2, y2");
            float x2 = Convert.ToSingle(Console.ReadLine());
            float y2 = Convert.ToSingle(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:f}", r);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Distance();
        }
    }
}
