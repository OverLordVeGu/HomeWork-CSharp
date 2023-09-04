// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear ();

int SetNumber (string message)  // Метод позволяющий пользователю ввести число
{
    Console.Write (message);
    int number = Convert.ToInt32 (Console.ReadLine ());
    return number;
}

double[,] FillMatrix (int rows, int columns, int minValue, int maxValue) // Метод заполняющий двумерный массив по заданным характеристикам
{
    double [,] matrix = new double [rows, columns];
    var random = new Random ();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix [i,j] = Math.Round ((random.Next (minValue, maxValue) + random.NextDouble ()),2);
        }
    }
    return matrix;
}

void PrintMatrix (double [,] matrix)  // Метод выводящий на печать двумерный массив с вещественными числами
{
    for(int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write ($"{matrix [i,j]} ");
        }
        Console.WriteLine();
    }
}

int rows = SetNumber ("Enter rows = ");
int columns = SetNumber ("Enter columns = ");
int minValue = SetNumber ("Enter minial value of random numbers = ");
int maxValue = SetNumber ("Enter maximal value of random numbers = ");
double [,] matrix = FillMatrix (rows, columns, minValue, maxValue);
PrintMatrix (matrix);   

