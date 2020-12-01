﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Александр Романов
// метод Подсчета количества цифр числа

namespace Подсчет_количества_цифор_числа
{
    class Program
    {

        static int AmountOfCharInNumber(string number)
        {
            return number.Length;
        }

        static string GetNumericString() //проверяем ввод
        {
            string number = "";
            bool checkNotAnumber;
            do
            {
                checkNotAnumber = false;
                number = Console.ReadLine();
                for (int i = 0; i < number.Length; i++)
                {
                    if (!Char.IsNumber(number, i))
                    {
                        checkNotAnumber = true;
                        Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста повторите ввод: ");
                        break;
                    }
                }
            } while (checkNotAnumber);
            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа подсчета количества цифр числа");
            Console.Write("Введите число: ");

            string number = GetNumericString();

            Console.WriteLine(Environment.NewLine + "Количество цифр: " + AmountOfCharInNumber(number));

            Console.ReadKey();
        }
    }
}
