using System;

namespace Cos_от_x
{
    class Program
    {
        static void Display(ref double[,] arr, int size, int xmax, int ymax)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Cos({0," + (-xmax) + "}) = {1," + (ymax) + "}",
                string.Format("{0:N2}", arr[i, 0]), string.Format("{0:N2}", arr[i, 1]));
            }
        }
        static void Main(string[] args)
        {
            // ввод шага с клавиатуры
            Console.Write("Шаг = ");
            double dx = Convert.ToDouble(Console.ReadLine());
            // вводим диапазон
            Console.Write("min X = ");
            double xmin = Convert.ToDouble(Console.ReadLine());
            Console.Write("max X = ");
            double xmax = Convert.ToDouble(Console.ReadLine());
            double x = xmin; // текущее значение Х
            double[,] mtrXY = new double[1000, 2]; // массив аргументов
            int currIndex = 0;// текущий индекс в массиве
            while (x <= xmax)
            {
                mtrXY[currIndex, 0] = x;// запишем в массив Х
                mtrXY[currIndex, 1] = Math.Cos(x);// запишем в массив У
                currIndex++;
                x += dx;// увеличение значения на шаг
            }
            Display(ref mtrXY, currIndex, 0, 0); // вызов функции для вывода полученных значений ХУ
            Console.ReadKey();
        }
    }
}
