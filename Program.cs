using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, komand;
            bool done = false;
            bool firstopen = true;
            while (!done)
            {
                if (firstopen)
                {
                    Console.WriteLine("Здравствуйте, список оппераций которые можно выполнить");
                    Console.WriteLine("1. Сложить первое число со вторым.");
                    Console.WriteLine("2. Вычесть из второго числа первое.");
                    Console.WriteLine("3. Умножить певоечисло на второе.");
                    Console.WriteLine("4. Разделиь первое число на второе.");
                    Console.WriteLine("5. Возведение в степень.");
                    Console.WriteLine("6. Крень кадратный числа.");
                    Console.WriteLine("7. 1% из числа.");
                    Console.WriteLine("8. Факториал числа.");
                    Console.WriteLine("9. Выход из программы.");
                    Console.WriteLine("10. Вывод списка команд.");
                    Console.Write("Введите номер операции: ");
                    firstopen = false;
                }
                else
                {
                    Console.WriteLine("Введите '10' если хотите вывести список оппераций.");
                    Console.Write("Введите номер операции: ");
                }
                komand = int.Parse(Console.ReadLine());

                switch (komand)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите первое число: ");
                            a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            b = float.Parse(Console.ReadLine());

                            Console.WriteLine("результат сложения ваших чисел: " + (a + b));
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введите первое число: ");
                            a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            b = float.Parse(Console.ReadLine());

                            Console.WriteLine("Результат  ваших вычитания чисел: " + (a - b));
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Введите первое число: ");
                            a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            b = float.Parse(Console.ReadLine());

                            Console.WriteLine("Результат умножения ваших чисел: " + (a * b));
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Введите первое число: ");
                            a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите второе число: ");
                            b = float.Parse(Console.ReadLine());

                            Console.WriteLine("Результат деления  ваших чисел: " + (a / b));
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Введите число: ");
                            a = float.Parse(Console.ReadLine());
                            Console.WriteLine("Введите степень: ");
                            b = float.Parse(Console.ReadLine());

                            Console.WriteLine("Результат возведения  ваших чисел: " + Math.Pow(a, b));
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Введите число: ");
                            a = float.Parse(Console.ReadLine());


                            Console.WriteLine("Результат квадратного корня: " + Math.Sqrt(a));
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Введите число: ");
                            a = float.Parse(Console.ReadLine());


                            Console.WriteLine("Результат одного процента : " + (a * 0.01));
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Введите число: ");
                            a = float.Parse(Console.ReadLine());
                            float anw = 1;
                            for (int i = 1; i <= 10; i++)
                                anw *= i;

                            Console.WriteLine("Результат факториала: " + (anw));
                        }
                        break;
                    case 9:
                        {
                            done = true;
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("1. Сложить первое число со вторым.");
                            Console.WriteLine("2. Вычесть из второго числа первое.");
                            Console.WriteLine("3. Умножить певоечисло на второе.");
                            Console.WriteLine("4. Разделиь первое число на второе.");
                            Console.WriteLine("5. Возведение в степень.");
                            Console.WriteLine("6. Крень кадратный числа.");
                            Console.WriteLine("7. 1% из числа.");
                            Console.WriteLine("8. Факториал числа.");
                            Console.WriteLine("9. Выход из программы.");
                            Console.WriteLine("10. Вывод списка команд.");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Неизвестна команда.");
                        }
                        break;
                }


            }


        }
    }
}