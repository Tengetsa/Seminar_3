// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
double number = double.Parse(Console.ReadLine()!);
string result = "";
int num = 1;

for (int i = 0; i < number; i++)
{
    double degree = Math.Pow(num, 3);
    result = result + degree + " | ";
    num += 1;
}

Console.WriteLine(result);

