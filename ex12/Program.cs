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
            const string CommandBack = "back";
            const string CommandChooseRace = "setrace";
            const string CommandChooseClassification = "setclass";
            const string CommandEnterLvl = "setlvl";
            const string CommandEnterName = "setname";

            bool isOpen = true;
            bool isCreateCharacter = true;
            string race = "";
            int level = 0;
            string name = "";
            string classification = "";

            while (isOpen)
            {
                Console.WriteLine($"Dungeon&Dragons\n");
                Console.WriteLine($"Ваш персонаж\nИмя: {name}\nРаса: {race}\nКласс: " +
                    $"{classification}\nУровень: {level}");
                Console.WriteLine("\nХотите создать нового персонажа?\n+ да\n- закрыть программу\n");
                Console.Write("Введите команду: ");
                char choiceCreate = Convert.ToChar(Console.ReadLine());

                if (choiceCreate == '+')
                {
                    isCreateCharacter = true;

                    while (isCreateCharacter)
                    {
                        Console.WriteLine($"\nSetName - ввести имя персонажа\nSetRace - ввести расу персонажа" +
                            $"\nSetClass - ввести класс персонажа\nSetLvl - ввести уровень персонажа\nBack - вернуться в начальное меню\n");
                        Console.Write("Введите команду: ");
                        string chosenOperation = Console.ReadLine();

                        switch (chosenOperation.ToLower())
                        {
                            case CommandEnterName:
                                Console.Write("Введите имя персонажа: ");
                                name = Console.ReadLine();
                                break;
                            case CommandEnterLvl:
                                Console.Write("Введите свой уровень: ");
                                level = Convert.ToInt32(Console.ReadLine());
                                break;
                            case CommandChooseClassification:
                                Console.Write("Введите свой класс: ");
                                classification = Console.ReadLine();
                                break;
                            case CommandChooseRace:
                                Console.Write("Введите свою расу: ");
                                race = Console.ReadLine();
                                break;
                            case CommandBack:
                                isCreateCharacter = false;
                                break;
                            default:
                                Console.WriteLine("Неверная команда. Попробуйте еще раз.");
                                break;
                        }
                    }
                }
                else if (choiceCreate == '-')
                {
                    isOpen = false;
                }
                else
                {
                    Console.WriteLine("Неверная команда. Попробуйте еще раз.");
                    Console.ReadKey();
                }

            }


        }
    }
}
