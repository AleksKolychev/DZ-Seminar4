Console.Clear();
Console.WriteLine("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите показатель степени: ");
int m = Convert.ToInt32(Console.ReadLine());
double Result = n;
for (int i = 1; i < m; i++)
    Result = n * Result;
Console.WriteLine(Result);