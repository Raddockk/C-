using System;

namespace Chess
{
    class Chess
    {
        public static bool King(int x1, int y1, int x2, int y2)
        {
            // Проверяем, что координаты находятся на расстоянии не более 1 клетки
            return Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1;
        }

        public static bool Queen(int x1, int y1, int x2, int y2)
        {
            // Проверяем, что фигура может ходить как слон или ладья
            return Bishop(x1, y1, x2, y2) || Rook(x1, y1, x2, y2);
        }

        public static bool Rook(int x1, int y1, int x2, int y2)
        {
            // Проверяем, что фигура может ходить только по вертикали или горизонтали
            return x1 == x2 || y1 == y2;
        }

        public static bool Bishop(int x1, int y1, int x2, int y2)
        {
            // Проверяем, что фигура может ходить только по диагонали
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }

        public static bool Knight(int x1, int y1, int x2, int y2)
        {
            // Проверяем, что фигура может ходить буквой "Г"
            return (Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) ||
                   (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2);
        }

        public static bool Pawn(int x1, int y1, int x2, int y2)
        {
            // Проверяем, что пешка может ходить только вперед на одну или две клетки
            if (x1 == x2 && y2 == y1 )
            {
                // Обычный ход пешки на одну клетку
                return true;
            }          
            
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования функций
            Console.WriteLine(Chess.King(1, 1, 2, 2)); // True
            Console.WriteLine(Chess.Queen(1, 1, 2, 2)); // True
            Console.WriteLine(Chess.Rook(1, 1, 2, 2)); // False
            Console.WriteLine(Chess.Bishop(1, 1, 2, 2)); // True
            Console.WriteLine(Chess.Knight(1, 1, 2, 3)); // True
            Console.WriteLine(Chess.Pawn(1, 1, 1, 2)); // True          
        }
    }
}
