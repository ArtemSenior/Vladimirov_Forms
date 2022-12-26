using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FНеделя4_Задание12
{
     internal class Point
     {
        public int x;
        public int y;

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
        public string showPoints() // Метод1 вывода координат точек
        {
            return $"x: {x}, y: {y}";
        }
        public string showCalculate() // Метод2 вывода расстояния от начала координат до точки 
        {
            double s;
            s = Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));
            return $"Расстояние от начала координат до точки: {s}";
        }
        public string Moving(int a, int b) // Метод3 вычисления и вывода координат точки после перемещения на вектор a,b
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
                
            }
        }
        public int SkalarY
        {
            set
            {
                }
        }
        // 12

        public int this[int index] // Индексаторы 0=x, 1=y, если не 0 и 1, то ошибка
        {
            get
            {
                if (index == 0) return x;
                if (index == 1) return y;
                else
                    throw new Exception("Ошибка");// в противном случае ошибка
            }
        }
        public static Point operator --(Point Ad) // Перегрузка операций ++ и --
        {
            Ad.x -= 1;
            Ad.y -= 1;
            return Ad;
        }

        public static Point operator ++(Point Ad)
        {
            Ad.x += 1;
            Ad.y += 1;
            return Ad;
        }        
        public static bool operator false(Point Ad) // перегрузка true или false, если они не равны, то false, иначе true
        {
            if (Ad.x != Ad.y)
                return false;
            return true;
        }

        public static bool operator true(Point Ad)
        {
            if (Ad.x == Ad.y)
                return true;
            return false;
        }
        public static Point operator +(Point Ad, int skalar) // бинарный +
        {
            Ad.x = Ad.x + skalar;
            Ad.y = Ad.y + skalar;
            return Ad;
        }
        public static Point operator +(int skalar, Point Ad)
        {
            Ad.x = Ad.x + skalar;
            Ad.y = Ad.y + skalar;
            return Ad;
        }        
        public static explicit operator String(Point obj) // преобразования типа Point в string (и наоборот)
        {
            return obj.x + ", " + obj.y;
        }

        public static explicit operator Point(string str)
        {
            string[] q = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Point obj = new Point();
            obj.x = int.Parse(q[0]);
            obj.y = int.Parse(q[1]);
            return obj;
        }
    }
}
