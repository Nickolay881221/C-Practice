//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49


int Promt(string message)
{
    System.Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int value = Promt("Введите число >");
int square = value * value;
System.Console.WriteLine($"Квадрат числа {value} равен {square}");

