// Напишите программу, которая будет выдавать название 
// дня недели по заданному номеру.

// int d = int.Parse(Console.ReadLine());
// Этой строкой можно заменить 2 строки кода
// указав методу Parse переменную указанную в 
// Console.ReadLine(), таким образом не нужно 
// будет вводить лишнюю переменную (day)

Console.WriteLine("Введите число:  ");

string day = Console.ReadLine();

int d = int.Parse(day);

if (d == 1)
{
  Console.WriteLine("Понедельник");
}

if (d == 2)
{
  Console.WriteLine("Вторник");
}

if (d == 3)
{
  Console.WriteLine("Среда");
}

if (d == 4)
{
  Console.WriteLine("Четверг");
}

if (d == 5)
{
  Console.WriteLine("Пятница");
}

if (d == 6)
{
  Console.WriteLine("Суббота");
}

if (d == 7)
{
  Console.WriteLine("Воскресенье");
}

else
{
  if(d > 7)
  Console.WriteLine("Нет такого дня недели");
}

