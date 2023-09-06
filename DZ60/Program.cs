// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[, ,] Fill3DMassive(int rows, int columns, int highs)   // Метод заполняющий трехмерный массив по заданным пользователем характеристикам
{
    int[, ,] massive = new int[rows, columns, highs];
    Random randomElement = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int l = 0; l < highs; l++)
            {
                massive[i, j, l] = randomElement.Next(10, 100);
            }
        }
    }
    return massive;
}

void Print3DMassive(int[, ,] matrix)     // Метод выводящий трехмерный массив на экран с индексами позиций
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                Console.Write($"{matrix[i, j, l]}({i}, {j}, {l})  ");
            }
            
        }
        Console.WriteLine();
    }
}

int[, ,] matrix = Fill3DMassive(2, 2, 2);
Print3DMassive(matrix);
