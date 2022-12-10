//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Random rnd = new Random();
int [] d = new int[30];
int max = 0, min = 100;
for (int i = 0; i < d.Length; i++) d[i] = rnd.Next(100);
for (int i = 0; i < d.Length; i++)
{
    if (d[i] > max) max = d[i];
    if (d[i] < min) min = d[i];
}

for (int i = 0; i < d.Length; i++) Console.Write(" " + d[i]);
Console.WriteLine();
Console.WriteLine("Максимальное число в массиве:  " + max);
Console.WriteLine("Минимальное число в массиве:  " + min);
Console.WriteLine("Разница между максимальным и минимальным:  " + (max - min));