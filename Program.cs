// Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();

int[] array = new int[] {1, 2, 3, 4, 5};
Console.Write("Введите число для проверки: ");
int num = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num) 
    {
        Console.WriteLine($"Число {num} есть в заданном массиве.");
        count++;
    }
}
if (count == 0) Console.WriteLine($"Число {num} в заданном массиве отсутствует.");