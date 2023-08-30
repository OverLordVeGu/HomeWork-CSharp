// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] FillArray(int M)   // Метод инициализирующий ввод чисел и преобразовывающий их в одномерный массив
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.Write("Enter number = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array) // Метод выводящий массив на печать
{
    Console.WriteLine(string.Join("  ", array));
}

int CountPossitive (int [] array) // Метод подсчитывающий колличество положительных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите количество чисел = "); 
int M = Convert.ToInt32(Console.ReadLine());  // Переменная ограничевающая колличество введенных чисел
int[] array = FillArray(M);
PrintArray(array);
int countPossitive = CountPossitive(array);
Console.WriteLine($"Колличество положительных чисел = {countPossitive}");
