using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, 
//рост, вес). В результате вся информация выводится в одну строчку.
namespace Homework1
{
    class Program
    { 
        static void Main(string[] args)
        {
            string name;
            string surname;
            int age;
            int height;
            int weight;

            Console.Write("Введите имя ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            surname = Console.ReadLine();
            Console.Write("Введите возраст ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" "+name+" "+surname+" "+age+ " "+height+" "+weight);

            Console.Read();
        }
    }
}
