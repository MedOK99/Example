// Напишите программу, которая на вход принимает число и выдаёт ео квадрат (число умноженное на само себя)
Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int result = number * number;

Console.WriteLine(result);
