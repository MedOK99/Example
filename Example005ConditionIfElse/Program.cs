// Папка 005 Программа приветствия по именам
Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "алексей")
{
    Console.WriteLine("Приветствую и повинуюсь, мой ПОВЕЛИТЕЛЬ!");
}

if(username.ToLower() == "олеся")
{
    Console.WriteLine("Счастлив приветствовать тебя, моя Богиня! Слушаю и повинуюсь!");
}

if(username.ToLower() == "таня")
{
    Console.WriteLine("О да! Это Таня! Здравия желаю тебе, моя Богиня!");
}

if(username.ToLower() == "миша")
{
    Console.WriteLine("ФИГАСЕ, это же МИША!!! Привет ШАЛУН!!!");
}

if(username.ToLower() == "соня")
{
    Console.WriteLine("Вот это да! Это же Соня! Привет ПРИНЦЕССА!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}