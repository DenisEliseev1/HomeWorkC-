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

void Zadacha21 ()
{
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    int [] pointA = new int [3];
    int [] pointB = new int [3];
    Console.WriteLine ("Введите координаты XYZ точки 1");
    AddArray (pointA);
    PrintArray (pointA);
    Console.WriteLine ("Введите координаты XYZ точки 2");
    AddArray (pointB);
    PrintArray (pointB);
    Console.WriteLine ("Расстояние между точкой 1 и точкой 2 = " + (Math.Sqrt (Math.Pow (pointA[0]-pointB[0],2)+Math.Pow (pointA[1]-pointB[1],2)+Math.Pow (pointA[2]-pointB[2],2))));

}

void Zadacha23 ()
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Console.Write ("Введите число N :");
    int number = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine ("Таблица кубов чисел от 1 до N:");
    for (int i = 1; i<=number; i++)
    {
        Console.WriteLine (i + "^3 = " + (Math.Pow (i,3)));
    }
}

void AddArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array [i] = Convert.ToInt32 (Console.ReadLine ());
    }
}
void PrintArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
    Console.WriteLine ();
}


//Zadacha19 ();
// Zadacha21 ();
Zadacha23 ();