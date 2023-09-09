// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int SetNumber (string message)  // Метод позволяющий пользователю ввести число
{
    Console.Write (message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string PrintRange (int number, int finish = 1) // Рекрсия с выводом чисел от N до 1
{
    if (number == finish)
    {
        return number.ToString();
    }
    return $" {PrintRange(number, finish +1)}, {finish}";
}

int number = SetNumber ("Введи число N = ");
Console.Write (PrintRange (number));