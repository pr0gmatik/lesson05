//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

NumRandom(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);

void NumRandom(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    var odd = numbers.Where((element, index) => index % 2 == 0);
    Console.WriteLine();
    Console.Write("Количество элементов стоящих на нечетных позициях равно: {0}. Их сумма: {1}.", odd.Count(), odd.Sum());
}