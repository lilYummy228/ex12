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
            bool isOpen = true;

            while (isOpen)
            {
                Console.Write("Введите команду: ");
                string chosenOperation = Console.ReadLine();

                switch (chosenOperation)
                {
                    case CommandExit:
                        isOpen = false;
                        break;
                }
            }

        }
    }
}
