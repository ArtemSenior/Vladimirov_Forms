using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FНеделя3_Задание11
{
    internal class Point
    {
        public int x;
        public int y;
        public int a;
        public int b;

        public Point() // Конструктор при нулевых координатах
        {
            x = 0;
            y = 0;
        }
        public Point(int X, int Y) // Конструктор при заданных координатах
        {
            x = X;
            y = Y;
        }
        public void ab(int A, int B) // Конструктор при заданных координатах
        {
            a = A;
            b = B;
        }
        public string showPoints() // Метод1 вывода координат точек
        {
            return $"x: {x}, y: {y}";
        }
        public string showPointsab() // 
        {
            return $"x: {a}, y: {b}";
        }
        public string showCalculate() // Метод2 вывода расстояния от начала координат до точки 
        {
            double s;
            s = Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));
            return $"Расстояние от начала координат до точки: {s}";
        }
        public string Moving(int a, int b) // Метод3 вычесления и вывода координат точки после перемещения на вектор a,b
        {
            x = x + a;
            y = y + b;
            return ($"Координаты точки после перемещения на вектор (a,b) x: {x}, y: {y}");
        }
        public int X // Свойства1 для записи и вывода координат точки
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }

        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }

        }
        public int SkalarX // Свойство2 позволяющее вывести умножить координаты точки на скаляр
        {
            set
            {
                x = x * value;
            }
        }
        public int SkalarY
        {
            set
            {
                y = y * value;
            }
        }
    }
}
