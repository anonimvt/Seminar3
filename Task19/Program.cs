Console.Clear();
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Это число является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} - Это число не является палиндромом");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} -Это число не является пятизначным");
}