﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Александр Романов
// Задание 3 С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Пока_не_будет_введен_0
{
    class Program
    {
        static int GetInt() //проверяем ввод
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста повторите ввод: ");
                else return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа подсчета нечетных положительных чисел");
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int AmountOfOddNumbers = 0;
            while (true)
            {
                int number = GetInt();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    AmountOfOddNumbers++;
                }
            }

            Console.WriteLine(Environment.NewLine + "Количество чисел: " + AmountOfOddNumbers);

            Console.ReadKey();
        }
    }
}