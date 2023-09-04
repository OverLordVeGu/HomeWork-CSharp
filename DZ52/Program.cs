// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Clear();

int SetNumber(string message)    // Метод позволяющий пользователю ввести число
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] FillDualMassive(int rows, int minValue, int columns, int maxValue)   // Метод заполняющий двумерный массив по заданным пользователем характеристикам
{
    int[,] dualMassive = new int[rows, columns];
    Random randomElement = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dualMassive[i, j] = randomElement.Next(minValue, maxValue);
        }
    }
    return dualMassive;
}

void PrintDualMassive(int[,] matrix)     // Метод выводящий двумерный массив на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

double ArithmeticMeanColumns(int[,] matrix)
{
    double mean = 0;
    double sum = 0;
    double sum2 = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         sum = sum + matrix[i, 0];        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                      
        }
        mean = Math.Round((sum / matrix.GetLength(1)),2);
    }
    
    return mean;
}

int rows = SetNumber("Enter rows = ");
int columns = SetNumber("Enter columns = ");
int minValue = SetNumber("Enter minimal value = ");
int maxValue = SetNumber("Enter maximal value = ");
int[,] matrix = FillDualMassive(rows: rows, columns: columns, minValue: minValue, maxValue: maxValue);
PrintDualMassive(matrix);
Console.WriteLine();
double mean = ArithmeticMeanColumns(matrix);
Console.Write($"Среднее арияметическое значение столбца = {mean}");


