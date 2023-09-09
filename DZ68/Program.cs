// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int SetNumber(string message)  // Метод позволяющий пользователю ввести число
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Akkerman(int numberM, int numberN) // Метод вычесляющий функцию Аккермана
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    if (numberN == 0 && numberM != 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));


}


int numberM = SetNumber("Введи число M = ");
int numberN = SetNumber("Введи число N = ");
Console.Write(Akkerman(numberM, numberN));


