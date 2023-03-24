
Console.WriteLine("Введите первое число  ");
string input = Console.ReadLine();
int number1 = int.Parse(input);
Console.WriteLine("Введите второе число  ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

if (number2 * number2 == number1)
{
  Console.WriteLine("Второе число является квадратом первого");
}
else
{
  Console.WriteLine("Второе число не является квадратом первого");
}