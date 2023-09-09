// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int SetNumber (string message)  // Метод позволяющий пользователю ввести число
{
    Console.Write (message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PrintRange (int numberM, int numberN, int sum = 0) // Рекурсия с выводом суммы натуральных чисел от M от N 
{ 
    if (numberM == numberN)
    {
        return numberN;
    }
    return numberM + PrintRange(numberM + 1, numberN);
}

int numberM = SetNumber ("Введи число M = ");
int numberN = SetNumber ("Введи число N = ");
Console.Write (PrintRange (numberM, numberN));