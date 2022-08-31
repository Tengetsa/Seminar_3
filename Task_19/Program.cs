// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

int firstNumber = number / 10000;
int secondNumber = number / 1000 % 10;
int fourthNumber = number / 10 % 10;
int fifthNumber = number % 10;

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Введено некоректное число.");
}
else if (firstNumber == fifthNumber & secondNumber == fourthNumber)
{
    Console.Write($"Число {number} палиндром");
}
else
{
    Console.Write($"Число {number} не является палиндромом");
}
