Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
int[] numbers = new int[size];


NumRandom(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int x = 0; x < numbers.Length; x++)
if (numbers[x] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void NumRandom(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
 void PrintArray(int[] args)
    {
        var rnd = new Random();
        var arr = new int[1];
 
        for (int i = 0; i < arr.Length; i++)
            Console.Write("{0}\t", arr[i] = rnd.Next(-100, 100));
        Console.WriteLine();
 
            var even = arr.Where((element, index) => index % 2 != 0);
            var odd = arr.Where((element, index) => index % 2 == 0);
 
            Console.WriteLine("Чётные. Количество: {0}. Сумма: {1}.", even.Count(), even.Sum());
            Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());
 
            Console.ReadKey();
        }