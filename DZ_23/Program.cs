//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
string? numberString = Console.ReadLine();
int x = int.Parse(numberString);
int index = 1;

if (x <= 0)
{
    x = x * (-1);
}
while (x >= index)
{
    var result = Math.Pow(index, 3); //index * index * index; возведение в куб
    index++;
    Console.WriteLine(result);
}