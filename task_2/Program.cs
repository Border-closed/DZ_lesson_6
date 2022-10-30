// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float vvod (string text)
{
    Console.Write(text);
    return float.Parse(Console.ReadLine());
}
try
{
float b1=vvod("Введите число b1  ");
float b2=vvod("Введите число b2  ");
float k1=vvod("Введите число k1  ");
float k2=vvod("Введите число k2  ");
float x = -b1/b2;
float y = k2*x+k1;
Console.WriteLine("Координаты точки пересечения прямых  ("+x+"; "+y+")");
}
catch
{
    Console.WriteLine("Вы ввели не число");
}