// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

int Promt1(string message)
{
    System.Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int firstNumber = Promt1("Введите число 1 >");
int secondNumber = Promt1("Введите число 2 >");

if (firstNumber == secondNumber*secondNumber)
{
System.Console.WriteLine("первое число равно квадрату второго");
}
else
{
    System.Console.WriteLine("первое число не равно квадрату второго");
}