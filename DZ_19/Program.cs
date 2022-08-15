//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ("Введите пятизначное число: ");
string? numberString = Console.ReadLine ();

var n = int.Parse (numberString!);
var number1 =  int.Parse (numberString!);
var number2 =  int.Parse (numberString!);
var number4 =  int.Parse (numberString!);
var number5 =  int.Parse (numberString!);

if (n < 10000 || n > 99999) 
{
   Console.WriteLine("ОШИБКА!!! Введите пятизначное число!"); 
}

else if (n < 100000 || n > 9999)
 {
  number1 = n / 10000;
  number5 = n % 10;
  number2 = (n % 10000) /1000;
  number4 = (n % 100) / 10;

  Console.WriteLine("Первая цифра: " + number1);
  Console.WriteLine("Пятая цифра: " + number5);
  Console.WriteLine("Вторая цифра: " + number2);
  Console.WriteLine("Четвертая цифра: " + number4);
  Console.WriteLine("Сравниваем первую и пятую цифру:");
  Console.WriteLine(number1 + "  и  " + number5);

  if (number1 == number5)
  { 
  Console.WriteLine("Сравниваем вторую и четвертую цифру.");  
  Console.WriteLine(number2 + "  и  " + number4);

  if (number2 == number4)
  Console.WriteLine("Число ПАЛИНДРОМ");
  else 
  Console.WriteLine("Число НЕ ПАЛИНДРОМ");
  }
else
  Console.WriteLine("Число НЕ ПАЛИНДРОМ");
 }
