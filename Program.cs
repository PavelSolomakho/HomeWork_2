// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear(); // Очистка терминала

Console.WriteLine("Задача 10 ");

Console.WriteLine("Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.WriteLine("Введи трёхзначное число: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine("вторая цифра этого числа: "+stringNumber[1]);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Задача 13 ");

Console.WriteLine("Выводит третью цифру заданного числа");

Console.Write("Введи число: ");

int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);

  if (anyNumberText.Length > 2)
    {
        Console.WriteLine("третья цифра: " + anyNumberText[2]);
    }
  else 
    {
        Console.WriteLine("-> третьей цифры нет");
    } 


    
    
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Задача 15 ");

Console.WriteLine("Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.Write("Введи цифру, обозначающую день недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
    {
        Console.WriteLine("этот день выходной");
    }
  else if (dayNumber < 1 || dayNumber > 7) 
    {
        Console.WriteLine("это вообще не день недели");
    }
  else 
        Console.WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);


