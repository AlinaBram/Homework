using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле 
//I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост: ");
            float h = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите вес: ");
            float m = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Индекс массы тела: " + m / (h * h));

            Console.ReadKey();
        }
    }
}
