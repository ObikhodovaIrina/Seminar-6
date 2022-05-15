//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ImputNumber (string numberName)
{
    Console.Write($"Введите число {numberName}: ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

Console.WriteLine("Введите четыре числа");
double b1 = ImputNumber("b1");
double b2 = ImputNumber("b2");
double k1 = ImputNumber("k1");
double k2 = ImputNumber("k2");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
Console.WriteLine($"Точка х = {x}, точка у = {y}");