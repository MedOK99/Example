﻿// Напишите программу, 
// которая на вход принимает одно 
// число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N..

Console.WriteLine("Введите число ");

int n = int.Parse(Console.ReadLine());

int min = -n;
int max = n;

for (int i = min; i <= max; i++)
  {
      Console.WriteLine(i);
  }