Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int i = 0; i < n; i ++)
    array[i] = new Random().Next(-1000, 1001);
Console.WriteLine($"[{string.Join(" ", array)}]");

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = 0;
foreach (int element in array)
{
    if (element == x)
    count ++;
}
Console.WriteLine($"Результат: {count}");