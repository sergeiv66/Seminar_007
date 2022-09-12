//Домашняя работа
//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Cоздание и заполнение элементами массива
// Matrix - прямоугольная табличка, которая состоит
// из m строк и n столбцов (табличка)
// m - cтрочки, n - столбцы, 0 - minRandom, 10 - maxRandom
double[,] GetMatrix(int m, int n, double minRandom, double maxRandom)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().NextDouble() * 10;
        }
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            double number = inputMatrix[i,j];
            string result = string.Format("{0:f1}",number);
            Console.Write(result + "\t"); // Tab между элементами
        }
        Console.WriteLine();
    }
}

// Получаем матрицу из rows строк и columns столбцов,
// элементы от 0 до 10
double[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Cоздание и заполнение элементами массива
// Matrix - прямоугольная табличка, которая состоит
// из m строк и n столбцов (табличка)
// m - cтрочки, n - столбцы, 0 - minRandom, 10 - maxRandom
int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
        }
        Console.WriteLine();
    }

    Console.Write("Введите номер строки: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца: ");
    int y = Convert.ToInt32(Console.ReadLine());

    if ((x > rows) || (y > columns)) Console.WriteLine("Такого элемента нет");
    else
    {
        Console.Write($"Значение элемента матрицы с такими координатами: {inputMatrix[x, y]}");
    }

}

// Получаем матрицу из rows строк и columns столбцов,
// элементы от 0 до 10
int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);
*/


//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Cоздание и заполнение элементами массива
// Matrix - прямоугольная табличка, которая состоит
// из m строк и n столбцов (табличка)
// m - cтрочки, n - столбцы, 0 - minRandom, 10 - maxRandom
int[,] GetMatrix(int m, int n, int minRandom, int maxRandom)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, matrix.GetLength(0) = m
    {
        // i, m, k, j
        for (int j = 0; j < n; j++) //matrix.GetLength(1) = n, столбцы
        {
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами
        }
        Console.WriteLine();
    }
}

// Получаем матрицу из rows строк и columns столбцов,
// элементы от 0 до 10
int[,] resultMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(resultMatrix);


 Console.WriteLine("Результат");
    for (int j = 0; j < resultMatrix.GetLength(0); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < resultMatrix.GetLength(1); i++)
        {
            sum += resultMatrix[i, j];
           // average = sum / resultMatrix.GetLength(1);
        }
        average = sum / resultMatrix.GetLength(1);
        string result = string.Format("{0:f2}",average);
        Console.WriteLine($"Среднее арифметическое элементов столбца {j}: {result} ");
        Console.WriteLine();
    }


