// Задача 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите длину массива");
try
{
int L = int.Parse(Console.ReadLine());
int [] massiv = new int [L];

try
{
void vvod (int [] massiv,string text)
{
    for (int i = 0; i<massiv.Length; i++)
   {
    Console.Write(text);
    massiv [i] = int.Parse(Console.ReadLine());
   }
}

vvod (massiv,"Введите число массива");

void print (int [] massiv)
{
    for (int i = 0; i<massiv.Length; i++)
   {
    Console.Write ($"{massiv[i]}"+", ");
   }
}
Console.WriteLine();
Console.Write("Введенный массив ");
print(massiv);
Console.WriteLine();

int positiv (int [] massiv)
{
    int count = 0;
    for (int i = 0; i<massiv.Length; i++)
   {
    if (massiv[i]>0) count++; 
   }
   return count;
}
Console.Write("Количество положительных чисел в массиве ");
Console.WriteLine(positiv(massiv));
}
catch
{
Console.WriteLine("Вы ввели не число");
}
}
catch
{
Console.WriteLine("Вы ввели не число");
}
