using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TooMach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Задача 1. Приветствие по имени");
            Console.WriteLine("Как тебя зовут? Напиши:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
            Console.ReadKey();*/

            /*

            Console.WriteLine("Задача 2. Деление двух чисел");
            Console.WriteLine("Введи число a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи число b");
            int b = int.Parse(Console.ReadLine());
            var div = a / b;
            Console.WriteLine($"Результат деления a на b: {div}");
            Console.ReadKey();

            */

            /*
            Console.WriteLine("Задача 3. Вывод следующей буквы в алфавите");
            Console.WriteLine("Введите букву:");
            char let = char.Parse(Console.ReadLine());
            int i = Convert.ToInt16(let);
            if (i == 1103)
            {
                Console.WriteLine("В алфавите после буквы 'я' нет букв");
                Console.ReadKey();
                
            }
            if (i == 1071)
            {
                Console.WriteLine("После буквы 'Я' в алфавите ничего нет!");
                Console.ReadKey();
                
            }
            if (i != 1103 & i != 1071)
            {
                int q = i + 1;
                char nextlet = (char)q;
                Console.WriteLine($"Следующая буква в алфавите: {nextlet}");
                Console.ReadKey();
            } */




            /*
            Console.WriteLine("Задача 4. Решение квадратного уравнения");
            Console.WriteLine("Введите коэфиценты:");
            int numone = int.Parse(Console.ReadLine());
            int numtwo = int.Parse(Console.ReadLine());
            int numfr = int.Parse(Console.ReadLine());
            int diskr = (numtwo * numtwo) - 4 * numone * numfr;
            
            
            if (diskr < 0)
            {
                Console.WriteLine("Корней нет");
                Console.ReadKey();
            }
            if (diskr == 0) 
            {
                int x = -numtwo / (2 * numone);
                Console.WriteLine($"Единственный корень уравнения:{x}");
                Console.ReadKey();
            }
            else
            {
                double diskr2 = Math.Sqrt(diskr);
                int diskr3 = Convert.ToInt16(diskr2);
                int x1 = ((-numtwo) + diskr3) / 2 * numone;
                int x2 = ((-numtwo) - diskr3) / 2 * numone;
                Console.WriteLine($"Первый корень уравнения:{x1} Второй корень уравнения: {x2}");
                Console.ReadKey();

            }*/


        }
    }
}
