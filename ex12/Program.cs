using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandRandom = "random";
            const string CommandClear = "clear";
            const string CommandAge = "age";
            const string CommandYear = "year";
            const string CommandPredict = "predict";

            bool isOpen = true;
            int age = 0;
            int maxAge = 101;
            int currentYear = 2023;

            while (isOpen)
            {
                Console.WriteLine($"{CommandAge} - ввести возраст\n{CommandYear} - расчитать год\n" +
                    $"{CommandRandom} - вывести случайное число\n{CommandPredict} - предсказать будущее\n" +
                    $"{CommandClear} - очистить консоль\n" +
                    $"{CommandExit} - выход из программы");
                Console.Write("Введите команду: ");
                string chosenOperation = Console.ReadLine();

                switch (chosenOperation)
                {
                    case CommandAge:
                        Console.Write("\nВведите возраст: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;

                    case CommandYear:
                        if (age != 0)
                        {
                            Console.Write("\nВведите год: ");
                            int year = Convert.ToInt32(Console.ReadLine());
                            int ageInYear = year - currentYear + age;
                            Console.WriteLine($"В {year} году вам будет {ageInYear} лет!\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nВы еще не ввели свой возраст\n");
                        }

                        break;

                    case CommandRandom:
                        Console.Write("Введите минимальное число: ");
                        int minValue = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите максимальное число: ");
                        int maxValue = Convert.ToInt32(Console.ReadLine());
                        Random randomValue = new Random();
                        int value = randomValue.Next(minValue, maxValue + 1);
                        Console.WriteLine($"Случайное число: {value}");
                        Console.ReadKey();
                        break;

                    case CommandPredict:
                        if (age != 0)
                        {
                            Random randomAge = new Random();
                            Console.WriteLine("\nПродолжите текст");
                            Console.Write("В каком возрасте я... ");
                            string prediction = Console.ReadLine();
                            int predictedAge = randomAge.Next(age, maxAge);
                            Console.WriteLine($"Я {prediction} в {predictedAge} лет");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nСначала введите свой возраст\n");
                        }

                        break;

                    case CommandClear:
                        Console.Clear();
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine("\nВведена неверная команда. Попробуйте еще раз\n");
                        break;
                }
            }
        }
    }
}
