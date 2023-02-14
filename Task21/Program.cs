Console.Clear();
int x1 = InputInt("Введите координату X первой точки: ");
int y1 = InputInt("Введите координату Y первой точки: ");
int z1 = InputInt("Введите координату Z первой точки: ");
int x2 = InputInt("Введите координату X второй точки: ");
int y2 = InputInt("Введите координату Y второй точки: ");
int z2 = InputInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка {length}");


// Функция ввода данных
int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}