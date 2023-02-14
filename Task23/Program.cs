int number = InputInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    int c = i*i*i;
    Console.Write($"{c} ");
}



// Функция ввода сообщения
int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}