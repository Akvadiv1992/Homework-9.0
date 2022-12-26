Console.Clear();
Console.Write("Введите начальное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число: ");
int m = Convert.ToInt32(Console.ReadLine());

void sumN (int n, int m, int sum)
{
    if (n > m) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от n до m: {sum}"); 
        return;
    }
    sum = sum + (n++);
    sumN(n, m, sum);
}
sumN(n, m, 0);