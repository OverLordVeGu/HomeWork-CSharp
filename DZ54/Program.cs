// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMatrix(int[,] matrix) // Метод сортирующий и перемещающий максимальное значение вправо построчно
{
    int temp = 0;    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[i,k+1])
                {
                    temp = matrix[i,k];
                    matrix [i,k] = matrix[i,k+1];
                    matrix [i,k+1] = temp;
                }
            }             
        }        
    }
}


int rows = SetNumber("Enter rows = ");
int columns = SetNumber("Enter columns = ");
int minValue = SetNumber("Enter minimal value = ");
int maxValue = SetNumber("Enter maximal value = ");
int[,] matrix = FillDualMassive(rows: rows, columns: columns, minValue: minValue, maxValue: maxValue);
PrintDualMassive(matrix);
Console.WriteLine();
SortMatrix(matrix);
Console.WriteLine();
PrintDualMassive (matrix);