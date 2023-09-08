// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear ();

int SetNumber (string message)    // Метод позволяющий пользователю ввести число
{
    Console.Write (message);
    int number = Convert.ToInt32 (Console.ReadLine ());
    return number;
}

int[,] FillDualMassive (int rows, int minValue, int columns, int maxValue)   // Метод заполняющий двумерный массив по заданным пользователем характеристикам
{
    int[,] dualMassive = new int[rows, columns];
    Random randomElement = new Random ();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dualMassive[i, j] = randomElement.Next (minValue, maxValue);
        }
    }
    return dualMassive;   
}

void PrintDualMassive (int[,] matrix)     // Метод выводящий двумерный массив на экран
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write ($"{matrix [i,j]} ");
        }
        Console.WriteLine ();
    }
}

int[] SumRows (int[,] matrix)
{
    int[] sumArray = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            sum = sum + matrix [i,j];                                             
        }
        sumArray [i] = sum;               
    }
    return sumArray;
}

void FindMinimalElement (int [] array)
{
    int min = array [0];
    int i = 0;
    for (; i < array.Length; i++)
    {
        if (array [i] < min)
        {
            min = array [i];
        }
    }
    Console.Write($"Строка № {i} имеет минимальную сумму элементов");
}


int rows = SetNumber ("Enter rows = ");
int columns = SetNumber ("Enter columns = ");
int minValue = SetNumber ("Enter minimal value = ");
int maxValue = SetNumber ("Enter maximal value = ");
int[,] matrix = FillDualMassive (rows:rows, columns:columns, minValue:minValue, maxValue:maxValue);
PrintDualMassive (matrix);
Console.WriteLine ();
int [] array = SumRows (matrix);
Console.Write(string.Join(",", array));
Console.WriteLine ();
FindMinimalElement (array);