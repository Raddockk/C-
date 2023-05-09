using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Посчитать факториал числа");
            Console.WriteLine("2. Вывести число из ряда Фибоначчи");
            Console.WriteLine("0. Выход");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите число: ");
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            Console.WriteLine($"Факториал числа {n} равен {Factorial(n)}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода числа");
                        }
                        break;
                    case 2:
                        Console.Write("Введите порядковый номер числа в ряду Фибоначчи: ");
                        if (int.TryParse(Console.ReadLine(), out int fib))
                        {
                            Console.WriteLine($"Число Фибоначчи под номером {fib} равно {Fibonacci(fib)}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода числа");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Выход");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода числа");
            }
            Console.WriteLine();
        } while (choice != 0);
    }

    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static int Fibonacci(int n)
    {
        if (n == 1)
        {
            return 0;
        }
        else if (n == 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}