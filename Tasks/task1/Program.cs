// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


//Console.WriteLine("Введите целое пятизначное число");
//int numberA = int.Parse (Console.ReadLine()); // пользовательский ввод

using System;

int number = 0;
while (true)
{
    Console.Write("Введите целое пятизначное число: ");

    if (int.TryParse(Console.ReadLine(), out number))
    break;
    else
    Console.WriteLine("Вы ввели неверное число");
            }

int oldValue = number;
int newValue = 0;

while (number > 0)
{
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
    }
    if (newValue == oldValue)
    Console.WriteLine("Число является палиндромом");
    else
    Console.WriteLine("Число не является палиндромом");
        


