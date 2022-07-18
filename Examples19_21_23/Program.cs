void Zadacha19 ()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.Write ("Введите число 1 :");
    int number = Convert.ToInt32 (Console.ReadLine ());
    int numberV = number;
    int numberP = 0;
    while (numberV>0)
    {
        numberP=numberP*10+numberV%10;
        numberV=numberV/10;
    }
    if (numberP == number)
    {
        Console.WriteLine ("Число является полиндромом");
    }
    else 
    {
        Console.WriteLine ("Число не является полиндромом");
    }

}
Zadacha19 ();