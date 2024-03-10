// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.


int Ack(int n, int m) // m - строка, n - столбец
{
    if (n == 0)
    {
        return (m + 1);
    }
    if (m == 0)
    {
        return Ack(n - 1, 1);
    }
    return Ack(n - 1, Ack(n, m - 1));

}

Console.WriteLine("Введите натуральное значение N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное значение M");
int m = Convert.ToInt32(Console.ReadLine());

int result = Ack(n, m);
Console.WriteLine(result);

