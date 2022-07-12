// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write ("Введите число 1 :");
int numberV = Convert.ToInt32 (Console.ReadLine ());
int numberP=0;
if (numberV/100 ==0)
    {
        Console.WriteLine ("Третьей цифры нет");
    }
while (numberV>0)
    {
        numberP=numberP*10+numberV%10;
        numberV=numberV/10;
    }
    Console.WriteLine ("Третья цифра числа - " + (numberP/100)%10);