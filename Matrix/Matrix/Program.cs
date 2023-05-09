class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк первой матрицы: ");
        int rows1 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов первой матрицы: ");
        int cols1 = int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[rows1, cols1];
        Console.WriteLine("Введите элементы первой матрицы:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Введите количество строк второй матрицы: ");
        int rows2 = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов второй матрицы: ");
        int cols2 = int.Parse(Console.ReadLine());
        int[,] matrix2 = new int[rows2, cols2];
        Console.WriteLine("Введите элементы второй матрицы:");
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Сложение матриц");
        Console.WriteLine("2. Вычитание матриц");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1 && rows1 == rows2 && cols1 == cols2)
        {
            int[,] result = new int[rows1, cols1];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.WriteLine("Результат сложения матриц:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else if (choice == 2 && rows1 == rows2 && cols1 == cols2)
        {
            int[,] result = new int[rows1, cols1];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            Console.WriteLine("Результат вычитания матриц:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Неверный выбор или размеры матриц не совпадают");
        }
    }
}
