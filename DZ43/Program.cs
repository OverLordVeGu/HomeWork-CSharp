// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

int EnterValue()  // Метод инициализирующий ввод числа
{
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double CountCrossDotX(double b1, double k1, double b2, double k2) // Метод считающий координату точки по оси Х
{
    double dotX = (b2 - b1) / (k1 - k2);
    return dotX;
}

double CountCrossDotY(double b1, double k1, double dotX) // Метод считающий координату точки по оси Y
{
    double dotY = k1 * (dotX) + b1;
    return dotY;
}

Console.Write("Введите значение b1 = ");
double b1 = EnterValue();
Console.Write("Введите значение k1 = ");
double k1 = EnterValue();
Console.Write("Введите значение b2 = ");
double b2 = EnterValue();
Console.Write("Введите значение k2 = ");
double k2 = EnterValue();
double dotX = CountCrossDotX(b1, k1, b2, k2);
double dotY = CountCrossDotY(b1, k1, dotX);
Console.Write($"Координаты точки пересечения ({dotX}; {dotY})");

