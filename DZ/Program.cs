using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Задание 1

            /*
            Console.WriteLine("Задание 1. Выведите число e с точностью до десятых");
            Console.WriteLine("Какое число вывести pi или e ?(пишите маленькими буквами и на английском):");
            string let = Console.ReadLine();
            Console.WriteLine("Введите сколько знаков после запятой нужно вывести:");
            int num = int.Parse(Console.ReadLine());
            if (let == "e")
            {
                Console.WriteLine(Math.Round(Math.E, num));
                Console.ReadKey();
            }
            if (let == "pi")
            {
                Console.WriteLine(Math.Round(Math.PI, num));
                Console.ReadKey();
            }*/

            // Задание 2

            /*
            Console.WriteLine("Задание 2. Выведите число одно под другим");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.ReadKey();*/

            // Задание 3

            /*
            Console.WriteLine("Задание 3. Выведите на экран четыре числа столбиком");
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвертое число:");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}\n");
            Console.ReadLine();*/

            // Задание 4

            /*
            Console.WriteLine("Задание 4. Вывод числа, которое больше на 10");
            Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num + 10;
            Console.WriteLine($"Результат: {num1}");
            Console.ReadKey();*/

            // Задание 5

            /*
            Console.WriteLine("Задание 5. Найти периметр квадрата");
            Console.WriteLine("Введите чему равна сторона квадрата:");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр квадрата равен: {side * 4}");
            Console.ReadKey();*/

            // Задание 6

            /*
            Console.WriteLine("Задание 6. Нахождение длины окружности и его площади");
            Console.WriteLine("Введите число, которое будет радиусом окружности:");
            int rad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Длина окружности равна: {2 * rad}Pi(где 'Pi' - математическая константа) \n Площадь окружности равна: {rad * rad}Pi(где 'Pi' - математическая константа)");
            Console.ReadKey();*/

            // Задание 7

            /*
            Console.WriteLine("Задание 7. Вывести y = cos(x)");
            Console.WriteLine("Введите число 'x':");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Значение y = {Math.Cos(num)}");
            Console.ReadKey();*/

            // Задание 8

            /*
            Console.WriteLine("Задание 8. Найти периметр трапеции");
            Console.WriteLine("Введите основания трапеции a и b \n Основание a: \n Основание b:");
            int anum = int.Parse(Console.ReadLine());
            int bnum = int.Parse(Console.ReadLine());
            if (anum == bnum)
            {
                Console.WriteLine("Это прямоугольник -_- \n ладно, так и быть..");
                Console.WriteLine("Введите высоту трапеции:");
                int height1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Периметр прямоугольника равен: {anum + bnum + 2 * Math.Sqrt(height1 * height1 + (anum - bnum) * (anum - bnum) / 4)}");
                Console.ReadKey();
            }
            Console.WriteLine("Введите высоту трапеции:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр трапеции равен: {anum + bnum + 2 * Math.Sqrt(height*height + (anum - bnum)* (anum - bnum)/4)}");
            Console.ReadKey();*/

            // Задание 9

            /*
            Console.WriteLine("Задание 9. Стоимость всей покупки");
            Console.WriteLine("Введи цену за 1 киллограмм конфет:");
            double kg1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи цену за 1 киллограмм яблок:");
            double kg2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи цену за 1 киллограмм печенья:");
            double kg3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи граммовку конфет, которую собираешься купить:");
            double gr1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи граммовку яблок, которую собираешься купить:");
            double gr2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи граммовку печенья, которую собираешься купить:");
            double gr3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость всех продуктов: {kg1 * gr1 + kg2 * gr2 + kg3 * gr3}");
            Console.ReadKey();*/

            // Задание 10

            /*
            Console.WriteLine("Задание 10. Вывести слова");
            Console.WriteLine("Мир Труд Май\nМир\n    Труд\n         Май");
            Console.ReadKey();*/

            // Задание 11

            /*
            Console.WriteLine("Задание 11. Перестановка переменных");
            Console.WriteLine("Введите первую переменную");
            string variable = Console.ReadLine();
            double num;
            Console.WriteLine("Введите вторую переменную");
            string variable2 = Console.ReadLine();
            if (variable.Contains(".") || variable2.Contains("."))
            {
                variable = variable.Replace(".", ",");
                variable2 = variable2.Replace(".", ",");
            }
            try
            {
                bool isnumber = double.TryParse(variable, out num);
                bool isnumber1 = double.TryParse(variable2, out num);
                if (isnumber == true & isnumber1 == true)
                {
                    Console.WriteLine($"Теперь первое число: {variable2} \nА второе число: {variable}");
                    Console.ReadKey();
                }
            }
            catch
            {             
            }
            Console.WriteLine("Упс.. Нам нужны только числа..");
            Console.ReadKey();*/

            // Задание 12

            /*
            Console.WriteLine("Задание 12. Программа для подсчета периметра");
            Console.WriteLine("Введите назавние фигуры, площадь или периметр которой хотите узнать(маленькими буквами и на русском):");
            Console.WriteLine("Нужно выбрать треугольник, четырехугольник или круг");
            string word = Console.ReadLine();
            if (word == "треугольник")
            {
                Console.WriteLine("Что вы хотите найти(введите маленькими буквами, пример: периметр):");
                string wordtr = Console.ReadLine();
                if (wordtr == "площадь")
                {
                    Console.WriteLine("Введите высоту треугольника:");
                    var h = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите основание треугольника:");
                    var bas = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Площадь треугольника равен: {(h * bas)/2}");
                    Console.ReadKey();
                }
                if (wordtr == "периметр")
                {
                    Console.WriteLine("Введите первую сторону треугольника:");
                    var a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону треугольника:");
                    var b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третью сторону треугольника:");
                    var c = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Периметр треугольника равен: {a + b + c}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Упс, мы такого не знаем..");
                    Console.ReadKey();
                }                       
            }
            if (word == "четырехугольник")
            {
                Console.WriteLine("Что вы хотите найти(введите маленькими буквами, пример: периметр):");
                string word4 = Console.ReadLine();
                if (word4 == "площадь")
                {
                    Console.WriteLine("Введите первую диагональ:");
                    var d1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вторую диагональ");
                    var d2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ввдеите угол между ними(в градусах и меньше 180 градусов)");
                    var corner = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Площадь четырехугольника равна: {(d1 * d2 * Math.Sin(corner))/2}");
                    Console.ReadKey();
                }    
                if (word4 == "периметр")
                {
                    Console.WriteLine("Введите первую сторону:");
                    var a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону:");
                    var b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третью сторону:");
                    var c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите четвертую сторону:");
                    var d = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Периметр треугольника равен: {a + b + c + d}");
                    Console.ReadKey();
                }    
                else
                {
                    Console.WriteLine("Упс.. Такое было не запланиравано)");
                    Console.ReadKey();
                }    
            }
            if (word == "круг")
            {
                Console.WriteLine("Введите, что вы хотите найти, маленькими буквами(периметр или площадь):");
                var wordkr = Console.ReadLine();
                if (wordkr == "площадь")
                {
                    Console.WriteLine("Введите радиус окружности:");
                    var rad = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Площадь окружности равна: {rad * rad}Pi (где Pi математическая константа");
                    Console.ReadKey();
                }    
                if (wordkr == "периметр")
                {
                    Console.WriteLine("Введите радиус окружности:");
                    var rad = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Периметр окружности равен: {2 * rad}Pi (где Pi математическая константа");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Упс.. Такое было не запланиравано)");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("Упс.. ты сделал что-то не так(");
                Console.ReadKey();
            }
            */

            // Задание 13

            /*
            Console.WriteLine("Задание 13. Вывод вашего числа");
            Console.WriteLine("Введите ваше число");
            try
            {
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Вы ввели число {num}");
            }
            catch
            {
            }
            Console.WriteLine("Это не число(");
            Console.ReadKey();*/

            // Задание 14
            /*
            Console.WriteLine("Задание 14. Вывод информации \n2кг\n13 17 ");
            Console.ReadKey();*/

            // Задание 15

            /*
            Console.WriteLine("Задание 15. Вывод случайных чисел ");
            Random num =  new Random();
            int value = num.Next();
            int value1 = num.Next();
            int value2 = num.Next();
            int value3 = num.Next(); 
            Console.WriteLine($"{value}\n{value1}\n{value2}\n{value3}");
            Console.ReadKey();*/

            // Задание 16

            /*
            Console.WriteLine("Задание 16, которое было в классной работе от Тумакова(Нахождение корней квадратного уравнения)");
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

            // Задание 17

            /*
            Console.WriteLine("Задание 17. Нахождение среднего арифметического и геометрического");
            Console.WriteLine("Введите первое число:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое равно: {(a + b) / 2}\nСреднее геометрическое равно: {Math.Sqrt(a * b)}");
            Console.ReadKey();*/

            //Задание 18

            /*
            Console.WriteLine("Задание 18. Вычисления расстояния между точками в координатной плоскости");
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("x1 = ");
            var x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            var y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("x2 = ");
            var x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            var y2 = int.Parse(Console.ReadLine());
            var lenx = Math.Abs(Math.Abs(x1) - Math.Abs(x2));
            var leny = Math.Abs(Math.Abs(y1) - Math.Abs(y2));
            var lenx1x2 = Math.Sqrt((lenx * lenx) + (leny * leny));
            Console.WriteLine($"Расстояние между точками: {lenx1x2}");
            Console.ReadKey();*/

            // Задание 19

            /*
            Console.WriteLine("Задание 19. Обмен значениями трех переменных");
            Console.WriteLine("Введите значение a:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b:");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c:");
            var c = int.Parse(Console.ReadLine());            
            Console.WriteLine("Выберите какой вариант вывести(а или б):");
            var let = Console.ReadLine();
            if (let == "а")
            {
                var a1 = b;
                var b1 = c;
                var c1 = a;
                Console.WriteLine($"{b1} {a1} {c1}");
                Console.ReadKey();
            }
            if (let == "б")
            {
                var a1 = c;
                var b1 = a;
                var c1 = b;
                Console.WriteLine($"{b1} {a1} {c1}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Такого нет..");
                Console.ReadKey();
            }*/

            // Задание 20

            /*
            Console.WriteLine("Задание 20. Сколько прошло часов/минут/секунд");
            Console.WriteLine("Введите количество секунд прошедших с начала суток:");
            var i = int.Parse(Console.ReadLine());
            if (i > 86400)
            {
                var t = i / 86400;
                var s = i % 86400;
                var m = s / 60;
                var h = m / 60;
                if (t == 1)
                {
                    Console.WriteLine($"Прошел {t} день\nчасов:{h}\nминут:{m}\nсекунд:{s} ");
                    Console.ReadKey();
                }
                if (2 <= t & t <= 4)
                {
                    Console.WriteLine($"Прошло {t} дня\nчасов:{h}\nминут:{m}\nсекунд:{s} ");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Прошло {t} дней\nчасов:{h}\nминут:{m}\nсекунд:{s} ");
                    Console.ReadKey();
                }                   
            }
            else
            {
                var t = i / 86400;
                var s = i % 86400;
                var m = s / 60;
                var h = m / 60;
                Console.WriteLine($"Прошло часов:{h}\nминут:{m}\nсекунд:{s} ");
                Console.ReadKey();
            }*/

            // Задание 21

            /*
            Console.WriteLine("Задание 21. Сколько квадратов можно уместить в прямоугольнике");
            Console.WriteLine("Введите стороны прямоугольника в мм:");
            Console.Write("Сторона а:");  var i = int.Parse(Console.ReadLine());
            Console.Write("Сторона b:"); var b = int.Parse(Console.ReadLine());
            var s = i * b;
            Console.Write("Введите сторону квадрата:"); var k = int.Parse(Console.ReadLine());
            var skk = k * k;
            var sk = s / skk;
            Console.WriteLine($"В этот прямоугольник можно уместить {sk} квадратов\n ответ на задачу данную в условии - 4");
            Console.ReadKey();*/

            // Задание 22

            /*
            Console.WriteLine("Задание 22. Поставить третий знак вперед");
            var i = Console.ReadLine();
            string q = i.Split(i[2])[0];
            Console.WriteLine($"{i[2]}{q}");
            Console.ReadKey();*/

            // Задание 23

            /*
            Console.WriteLine("Задание 23. Вывести кол-во сотен и тысяч");
            Console.Write("Введите число больше 999:"); var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Кол-во сотен:{n / 100}\nКол-во тысяч:{n / 1000}"); Console.ReadKey();
            */

            //Задание 24

            /*
            Console.WriteLine("Задание 24. Работа с четырехзначным числом");
            Console.Write("Введите число: "); var i = int.Parse(Console.ReadLine());
            string s = i.ToString();
            Console.WriteLine($"{s[3]}{s[2]}{s[1]}{s[0]}\n{s[1]}{s[0]}{s[3]}{s[2]}\n{s[0]}{s[2]}{s[1]}{s[3]}\n{s[2]}{s[3]}{s[0]}{s[1]}");
            Console.ReadKey();*/

            // Задание 25

            /*
            Console.WriteLine("Задание 25.Задание с нахождение х\nВведите число n(100 <= n <= 999):");
            var n = int.Parse(Console.ReadLine());
            string n1 = n.ToString();
            int x3 = n / 100;
            var n2 = n % 100;
            var n3 = n2 * 10;
            var x = n3 + x3;
            Console.WriteLine($"Число х = {x}"); Console.ReadKey();*/

            // Задание 26

            /*
            Console.Write("Задание 26. Часовая стрелка\nВведите число, отвечающее за часы(0 <= h <= 23): ");
            var hours = int.Parse(Console.ReadLine());
            Console.Write("Введите число, отвечающее за минуты(0 <= m <= 59): ");
            var minute = int.Parse(Console.ReadLine());
            Console.Write("Введите число, отвечающее за секунды(0 <= s <= 59): ");
            var sec = int.Parse(Console.ReadLine());
            double grad = 360.0 / 86400.0;
            var gengrad = (hours * 3600 + minute * 60 + sec) * grad;
            Console.WriteLine($"С начала суток стрелка сдвинулась на {gengrad} градусов");
            Console.ReadKey();*/

            // Задание 27

            /*
            Console.Write("Задание 27. Часовая стрелка с доп условием\nВведите число, отвечающее за часы(0 <= h <= 23):");
            double hours = double.Parse(Console.ReadLine());

            var minute = hours * 60;
            
            double grad = 360.0 / 3600;
            Console.WriteLine("По условию задачи количество градусов часовой стрелки почему-то в пределах 0 и 2, но..");
            var gengrad = grad * (minute * 60);
            Console.WriteLine($"Минутная стрелка находится на {gengrad} градусах");
            Console.ReadKey();*/

            // Задание 28

            /*
            Console.Write("Задание 28. Вывод меньшего из чисел по модулю\nВведите первое число:");
            var value1 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.Write("Введите второе число:");
            var value2 = Math.Abs(int.Parse(Console.ReadLine()));
            Console.Write("Введите третье число:");
            var value3 = Math.Abs(int.Parse(Console.ReadLine()));
            var genvalue = Math.Min(value1, value2);
            var genvalue2 = Math.Min(value2, value3);
            var genvalue3 = Math.Min(value1, value3);
            var genvalue4 = Math.Min(genvalue, genvalue2);
            var genvalue5 = Math.Min(genvalue4, genvalue3);
            Console.WriteLine($"Меньшее из трех чисел: {genvalue5}");
            Console.ReadKey();*/

            // Задание 29

            /*
            Console.Write("Задание 29. Найти сумму большего и меньшего из трех чисел\nВведите первео число: ");
            var num = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            var num2 = int.Parse(Console.ReadLine());
            var genvalue1 = Math.Min(num, num1);
            var genvalue2 = Math.Min(num, num2);
            var genvalue3 = Math.Min(num1, num2);
            var genvalue4 = Math.Min(genvalue1, genvalue2);
            var genvalue5 = Math.Min(genvalue4, genvalue3);
            var genvalue6 = Math.Max(num, num1);
            var genvalue7 = Math.Max(num, num2);
            var genvalue8 = Math.Max(num1, num2);
            var genvalue9 = Math.Max(genvalue6, genvalue7);
            var genvalue10 = Math.Max(genvalue9, genvalue8);
            Console.WriteLine($"Сумма большего и меньшего равна: {genvalue10 + genvalue5}");
            Console.ReadKey();*/

            // Задание 29

            /*
            Console.Write("Задание 29. Найти сумму большего и меньшего из трех чисел\nВведите первео число: ");
            var num = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            var num2 = int.Parse(Console.ReadLine());
            int[] lists = new int[] { num1, num2, num };
            Console.WriteLine($"Сумма наибольшего и наименьшего: {lists.Max() + lists.Min()}");
            Console.ReadKey();*/

            // Задание 30

            /*
            Console.Write("Задание 30. Подсчитать количество делитей\nВведите число: ");
            var i = int.Parse(Console.ReadLine());
            var w = 0;
            List<int> ints = new List<int>() { };
            for (int q = 1; q <= i; q++)

            {
                if (i % q == 0)
                {
                    w++;
                    ints.Add(q);
                }
            }
          

            Console.WriteLine($"Количество делителей числа: {w}");
            
            foreach (var intes in ints)
            {
                Console.WriteLine($"Делители: {intes}");
            }
            Console.ReadKey();*/

            // Задание 31

            /*
            Console.Write("Задание 31. Нахождение корней кубического уравнения\nВведите первый коэфицент: ");
            var kef1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второй коэфицент: ");
            var kef2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третий коэфицент: ");
            var kef3 = int.Parse(Console.ReadLine());
            Console.Write("Введите четвертый коэфицент: ");
            var kef4 = int.Parse(Console.ReadLine());
            var num = 100;
            for (int i = -100; i <= 100; i++)
            {
                if ((kef1 * Math.Pow(i,3) + kef2 * Math.Pow(i,2) + kef3 * i + kef4) == 0)
                {
                    Console.WriteLine($"Корень найден: {i}");
                    
                }
                i++;
            }
            Console.ReadKey();*/

            // Задание 32

            /*
            Console.Write("Задание 32. Нахождение элемента арифметической прогрессии\nВведите первое число: ");
            var i = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var q = int.Parse(Console.ReadLine());
            Console.Write("Введите номер числа, которое хотите увидеть: ");
            var num = int.Parse(Console.ReadLine());
            if (i > q)
            {
                var d1 = -(i - q);
                var numi1 = i + d1 * (num - 1);
                Console.WriteLine($"Ваше число {numi1}");
                Console.ReadKey();
            }
            else
            {
                var d = q - i;
                var numi = i + d * (num - 1);
                Console.WriteLine($"Ваше число {numi}");
                Console.ReadKey();
            }*/

            // Задание 33

            /*
            Console.Write("Задание 33. Студент или старик\nКем вы являетесь(студент/старик/студент и старик)(пишите маленькими буквами): ");
            var word = Console.ReadLine();
            if (word == "студент")
            {
                Console.Write("Вы трудоустрены(напишите маленькими буквами да или нет)? ");
                var word1 = Console.ReadLine();
                if (word1 == "да")
                {
                    Console.WriteLine("Пенсии не будет, иди отсюда");
                    Console.ReadKey();
                }
                if (word1 == "нет")
                {
                    Console.WriteLine("Иди работать, но пенсия будет");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ты играешь не по тем правилам");
                    Console.ReadKey();
                }
            }
            if (word == "старик")
            {
                Console.Write("Вы трудоустрены(напишите маленькими буквами да или нет)?" );
                var word1 = Console.ReadLine();
                if (word1 == "да")
                {
                    Console.WriteLine("Пенсии не будет, иди отсюда");
                    Console.ReadKey();
                }
                if (word1 == "нет")
                {
                    Console.WriteLine("Иди работать, но пенсия будет");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ты играешь не по тем правилам");
                    Console.ReadKey();
                }
            }
            if (word == "студент и старик")
            {
                Console.WriteLine("Бери пенсию и иди отсюда");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ты что-то путаешь");
                Console.ReadKey();
            }*/

            // Задание 34

            /*
            Console.Write("Задание 34. Имя и экран\n Введите имя: ");
            var i = Console.ReadLine();
            Console.WriteLine($"{i}");
            Console.WriteLine($"Привет {i}");
            Console.ReadKey();*/

            // Задание 35

            /*
            Console.WriteLine("Задание 35. Гарри Поттер и Тайная комната");
            var word = Console.ReadLine();
            Console.WriteLine("Дневник.\n-Как тебя зовут?");
            var word1 = Console.ReadLine();
            Console.WriteLine($"Дневник.\n-Привет, {word1}");
            Console.WriteLine("Спроси, знает ли дневник что нибудь про тайную комнату");
            var word2 = Console.ReadLine();
            Console.WriteLine("Дневник.\n-Да.");
            Console.WriteLine("Спроси, можно ли узнать про нее");
            var word3 = Console.ReadLine();
            Console.WriteLine("Дневник.\n-Нет.");
            Thread.Sleep(5000);
            Console.WriteLine("Дневник.\nНо могу показать");
            Random r = new Random();
            Console.BackgroundColor = (ConsoleColor)r.Next(0, 16);
            Console.Clear();
            Console.ReadKey();*/

            // Задание 36

            /*
            Console.WriteLine("Задание 36. Нахождение контрольной цифры в штрихкоде");
            Random random = new Random();
            var i = random.Next(0,9);
            string i1 = i.ToString();
            var o = random.Next(0, 9);
            string o1 = o.ToString();
            var p = random.Next(0, 9);
            string p1 = p.ToString();
            var u = random.Next(0, 9);
            string u1 = u.ToString();
            var y = random.Next(0, 9);
            string y1 = y.ToString();
            var t = random.Next(0, 9);
            string t1 = t.ToString();
            var r = random.Next(0, 9);
            string r1 = r.ToString();
            var e = random.Next(0, 9);
            string e1 = e.ToString();
            var w = random.Next(0, 9);
            string w1 = w.ToString();
            var q = random.Next(0, 9);
            string q1 = q.ToString();
            var a = random.Next(0, 9);
            string a1 = a.ToString();
            var s = random.Next(0, 9);
            string s1 = s.ToString();
            var d = random.Next(0, 9);
            string d1 = d.ToString();
            Console.WriteLine("Введите 13 своих чисел(0 <= число <= 9) Вводите сразу все");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());
            var num5 = int.Parse(Console.ReadLine());
            var num6 = int.Parse(Console.ReadLine());
            var num7 = int.Parse(Console.ReadLine());
            var num8 = int.Parse(Console.ReadLine());
            var num9 = int.Parse(Console.ReadLine());
            var num10 = int.Parse(Console.ReadLine());
            var num11 = int.Parse(Console.ReadLine());
            var num12 = int.Parse(Console.ReadLine());
            var num13 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Штрихкод со случайными цифрами: {i1} {o1}{p1}{i1}{u1}{y1}{t1}{r1} {e1}{w1}{q1}{a1}{s1}{d1}\nКонтрольная цифры: {d1}");
            Console.WriteLine($"Штрихкод с вашими числами: {num1}  {num2}{num3}{num4}{num5}{num6}{num7} {num8}{num9}{num10}{num11}{num12}{num13}\nКонтрольная цифры: {num13}");
            Console.ReadKey();*/
        }

    }
}
