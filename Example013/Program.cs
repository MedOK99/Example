// Напишите программу, которая на 
// вход принимает число и выдаёт, является 
// ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine());

int r = a % 2;
if (r != 0)
{
  Console.WriteLine("Вы ввели НЕчётное число");
}

else
{
  r = 0;
  Console.WriteLine("Вы ввели чётное число");
}
