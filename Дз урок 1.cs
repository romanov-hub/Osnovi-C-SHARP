using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вебинар_1
{
    // Александр Романов
    class Program
    {

     /// Условия задачи: 1. Написать программу «Анкета». 
     /// Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
     /// В результате вся информация выводится в одну строчку.

        private static void Main()
            {
                Console.WriteLine("Привет! ");
                Console.Write("Напиши своё имя: ");
                string str1 = Console.ReadLine();

                Console.Write("Напиши свою фамилию: ");
                string str2 = Console.ReadLine();

                Console.Write("Напишите ваш возраст: ");
                string str3 = Console.ReadLine();

                Console.Write("Напишите Ваш вес: ");
                string str4 = Console.ReadLine();

                Console.Write("Напишите Ваш рост : ");
                string str5 = Console.ReadLine();
                Console.WriteLine("Что ж, вот что у нас получилось. Имя: " + str1 + "," + " Фамилия: " + str2 + "," + " Ваш возраст: " + str3 + "," + " Ваш вес: " + str4 + "," + " Ваш рост: " + str5);
                Console.Write("Пока! ");
                Console.ReadLine();


                // Условия  задачи: Ввести вес и рост человека.
                // Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
                // где m — масса тела в килограммах, h — рост в метрах



                double h;
                double m;
                Console.Write("Введите ваш рост в метрах: ");
                string str = Console.ReadLine();
                h = Convert.ToDouble(str);
                Console.Write("Введите ваш вес килограммах: ");
                m = Convert.ToDouble(Console.ReadLine());
                double I = m / (h * h);
                Console.WriteLine("Ваш индекс массы тела составляет: " + I);
                Console.ReadLine();


                // Условия задачи:  Написать программу обмена значениями двух переменных.

                int a;
                int b;
                Console.Write("Введите численное значение переменной а: ");
                string st1 = Console.ReadLine();
                a = Convert.ToInt32(st1);

                Console.Write("Введите численное значение переменной b: ");

                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Производится обмен значениями двух переменных.");


                int t = a;
                a = b;
                b = t;
                Console.WriteLine("Итого: Значение переменной а равно:" + a + "," + " Значение переменной b равно:" + b);
                Console.ReadLine();
            }


        }
    }