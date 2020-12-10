using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 * *а) Реализовать класс для работы с двумерным массивом. 
 * Реализовать конструктор, заполняющий массив случайными числами. 
 * Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
 * возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
 * возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
 * *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 * в) Обработать возможные исключительные ситуации при работе с файлами.
 * 
 * Александр Романов
 */

namespace Двумерный_массив
{
    class Program
    {
        private const string V = "Максимальный элемент массива: ";
        private const string V1 = "Минимальный элемент массива: ";
        private const int V2 = 0;

        /// <summary>Метод считывает строку и проверяет на корректный целочисленный ввод</summary>
        /// <returns></returns>
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа демонстрации возможностей класса для работы с двумерным массивом");

            Console.Write("Введите желаемое количество строк массива: ");
            int size1 = GetInt();
            Console.Write("Введите желаемое количество столбцов массива: ");
            int size2 = GetInt();


            myDimensionalArray a = new myDimensionalArray(size1, size2);

            Console.WriteLine("\nСоздан массив: ");

            a.PrintDinArr(a.toString());

            long sum = 0;
            a.Sum(out sum);

            Console.WriteLine("Сумма элементов массива: " + sum);

            a.SumMoreThan(out sum, a[V2, 0]);
            Console.WriteLine("Cумма элементов массива, которые больше, первого элемента: " + sum);

            Console.WriteLine(V + a.Max);

            Console.WriteLine(V1 + a.Min);

            string numOfMax = "";
            a.IndexOfMax(out numOfMax);
            Console.WriteLine("Номер максимального элемента: " + numOfMax);

            Console.WriteLine("=============================================================");

            myDimensionalArray myDimArr = new myDimensionalArray();

            string fileName = "loadArray.txt";
            string fileName2 = "saveArray.txt";

            myDimArr.loadFromFile(fileName);

            Console.WriteLine("\nЗагрузим массив из файла  " + fileName + " при помощи метода.");
            Console.WriteLine("Загружен следующий массив: ");

            myDimArr.PrintDinArr(myDimArr.toString());

            Console.WriteLine("\nСохраним массив в файл " + fileName2 + " при помощи метода.");

            myDimArr.saveIntoFile(fileName2);

            myDimensionalArray anotherDimArr = new myDimensionalArray(fileName2);

            Console.WriteLine("Проверим содержимое файла, загрузив из него новый массив: ");

            anotherDimArr.PrintDinArr(anotherDimArr.toString());

            Console.ReadKey();
        }
    }

    internal class myDimensionalArray
    {
        internal object a;

        public myDimensionalArray(int size1, int size2)
        {
        }

        internal void PrintDinArr(object p)
        {
            throw new NotImplementedException();
        }

        internal void Sum(out long sum)
        {
            throw new NotImplementedException();
        }

        internal void SumMoreThan(out long sum, object p)
        {
            throw new NotImplementedException();
        }

        internal object toString()
        {
            throw new NotImplementedException();
        }
    }
}