using System;
using System.Collections.Generic;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddNewNumbers = "1";
            const string CommandSumNumbers = "2";
            const string CommandExitProgramm = "3";

            List<int> numbers = new List<int>();

            string userInput;
            bool isOpen = true;

            while(isOpen) 
            {
                Console.WriteLine(CommandAddNewNumbers + " - добавить новое число ");
                Console.WriteLine(CommandSumNumbers + " - вывести сумму ");
                Console.WriteLine(CommandExitProgramm + " - выход из программы ");

                Console.Write("Выберите команду");
                userInput= Console.ReadLine();

                Console.Clear();

                switch(userInput)
                {
                    case CommandAddNewNumbers:
                        AddNewNumber(numbers); 
                        break;
                    case CommandSumNumbers:
                        WriteAmount(numbers);
                        break;
                    case CommandExitProgramm:
                        isOpen= false;
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }

                if(isOpen)
                    GetUserClick();
            }
        }

        static void GetUserClick()
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу");

            Console.ReadKey(true);
            Console.Clear();
        }

        static void WriteAmount(List<int> numbers)
        {
            int sumOfNumbers = 0;
            
            foreach (int number in numbers)
            {
                sumOfNumbers += number;

                Console.WriteLine($"Сумма = {sumOfNumbers}");
            }
        }

        static void AddNewNumber(List<int> number)
        {
            int newNumber;

            Console.Write("Новое число = ");
            bool numberSubmited = int.TryParse(Console.ReadLine(), out newNumber);

            if (numberSubmited)
            {
                number.Add(newNumber);
                Console.WriteLine("Новое число добавлено ");
            }
            else
            {
                Console.WriteLine("Ввели неверный формат");
            }

        }
    }
}
