using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и 
 * заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов массива, 
 * метод Inverse, меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount,
 * возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.
 * б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 * 
 * Александр Романов
 */

namespace Класс_работы_с_одномерным_массивом
{
    class Program
    {
        private const string V = "Сумма элементов массива: ";
        private const string V1 = "Максимальный элемент массива: ";

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
            Console.WriteLine("Вас приветствует программа демонстрации возможностей класса для работы с массивом");
            Console.Write("Введите желаемый размер массива: ");
            int size = GetInt();
            Console.Write("Введите первый элемент массива: ");
            int firstElement = GetInt();
            Console.Write("Введите шаг для добавления последующих элементов: ");
            int step = GetInt();

            MyArray a = new MyArray(size, firstElement, step);

            Console.WriteLine("\nСоздан массив: [ " + a.ToString() + " ]\n");

            Console.WriteLine(V + a.Sum);

            a.Inverse = -1;

            Console.WriteLine("Массив с изменёнными знаками: [ " + a.ToString() + " ]\n");

            Console.Write("Введите число, на которое будут умножены элементы массива: ");

            a.Multi = GetInt();

            Console.WriteLine("Массив, умноженный на число: [ " + a.ToString() + " ]\n");

            Console.WriteLine(V1 + a.Max);

            Console.WriteLine("Количество максимальных элементов массива: " + a.MaxCount);

            Console.WriteLine("=============================================================");
            Console.WriteLine("\nДалее массив создаётся загрузкой данных из файла.");

            string fileName = "..\\..\\array.txt";
            MyArray myArray = new MyArray(fileName);

            Console.WriteLine("Создан следующий массив: [ " + myArray.ToString() + " ]\n");

            string fileName2 = "..\\..\\anotherArray.txt";

            Console.WriteLine("\nЗагрузим массив из файла при помощи метода.");

            myArray.loadFromFile(fileName2);

            Console.WriteLine("Загружен следующий массив: [ " + myArray.ToString() + " ]\n");

            Console.WriteLine("\nСохраним массив в файл " + fileName + " при помощи метода.");

            myArray.saveIntoFile(fileName);

            MyArray myArray2 = new MyArray(fileName);

            Console.WriteLine("Проверим содержимое файла, загрузив из него новый массив: [ " + myArray2.ToString() + " ]\n");

            Console.ReadKey();
        }
    }

    internal class MyArray
    {
        private int size;
        private int firstElement;
        private int step;
        private string fileName;

        public MyArray(string fileName)
        {
            this.fileName = fileName;
        }

        public MyArray(int size, int firstElement, int step)
        {
            this.size = size;
            this.firstElement = firstElement;
            this.step = step;
        }

        public int Inverse { get; internal set; }
        public int Multi { get; internal set; }
        public string MaxCount { get; internal set; }

        internal void loadFromFile(string fileName2)
        {
            throw new NotImplementedException();
        }

        internal void saveIntoFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}