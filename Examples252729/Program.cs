void Zadacha25 ()
{
    //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16
    Random rand = new Random();
    int NumA = rand.Next (1, 7);
    int NumB = rand.Next (1, 7);
    Console.WriteLine ("Число А = " + NumA);
    Console.WriteLine ("Число B = " + NumB);
    Console.WriteLine ("А^B = " + Math.Pow (NumA, NumB));
    
}

void Zadacha27 ()
{
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    
}

void Zadacha29 ()
{
    // Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.
    
}

Zadacha25 ();