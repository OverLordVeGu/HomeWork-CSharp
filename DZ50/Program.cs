// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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


bool CheckElement (int [,] matrix, int element)   // Метод проверяющий наличие элемента в матрице
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            if (matrix [i, j] == element) return true;
        }
    }
    return false;        
}

void FindElement (int [,] matrix, int element)   // Метод нахождения элемента в матрице
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            if (matrix [i, j] == element) 
            {
                Console.WriteLine ($"Число {element} находиться на позиции matrix ({i}, {j})");
            }
        }
    }
           
}

int rows = SetNumber ("Enter rows = ");
int columns = SetNumber ("Enter columns = ");
int minValue = SetNumber ("Enter minimal value = ");
int maxValue = SetNumber ("Enter maximal value = ");
int[,] matrix = FillDualMassive (rows:rows, columns:columns, minValue:minValue, maxValue:maxValue);
PrintDualMassive (matrix);
Console.WriteLine ();
int element = SetNumber ("Enter element = ");
bool result = CheckElement (matrix, element);
if (result == true) FindElement (matrix, element);
else Console.WriteLine ($"{element} -> такого числа нет в массиве");





