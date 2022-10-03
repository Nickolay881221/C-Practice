// Напишите программу вычисления функции:
//  x = f(a)

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2

int Promt1(string message)
{
    System.Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int Number = Promt1("Введите число");
int Count = - Number;
while (Count <= Number) 
{
    System.Console.WriteLine(Count);
    Count = Count + 1;
}