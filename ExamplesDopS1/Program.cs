// Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
// N = 4 -> 1, 1, 1, 1
// N = 2 -> 1, 1

void Zad1 ()
{
    Console.Write ("Введите количество требуемых единиц :");
    int num = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ($"N = {num} -> ");
    for (int i = 0; i < num; i++)
    {
        Console.Write ("1,");
    }
    Console.WriteLine ("\b  ");
}
// Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.

void Zad2 ()
{
    Console.Write ("Введите A : ");
    int numA = Convert.ToInt32 (Console.ReadLine ());
    Console.Write ("Введите B : ");
    int numB = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine ("А в числе В поместиться " + (numB/numA) + " раз");
}

// Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.

void Zad3 ()
{
    Console.Write ("Введите количество спортсменов :");
    int NumS = Convert.ToInt32 (Console.ReadLine ());
    int [] rost = new int [NumS];
    Console.WriteLine ("Рост спортсменов :");
    AddArray (rost);
    PrintArray (rost);
    int help = 0;
    for (int i = 0; i < NumS-1; i++)
    {
        int max = i;
        for (int j = i+1; j < NumS; j++)
        {
            if (rost [j] > rost[max])
            {
                
                help = rost [j];
                rost [j] = rost [max];
                rost [max] = help;
            }
        }
    }
    Console.WriteLine ("Сортировка по росту :");
    PrintArray (rost);
}

// Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
// N = 72334 -> 20:5:34 

void Zad4 ()

{
    Console.Write ("Введите количество секунд :");
    int Sec = Convert.ToInt32 (Console.ReadLine ());
    Console.WriteLine ($"Время в фармате Ч:М:С -> {Sec/3600} : {(Sec/60)%10} : {Sec%100}");
}

void AddArray (int [] array)
{
    Random rand = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array [i] = rand.Next (180, 201);
    }
}

void PrintArray (int [] array)
{

    for (int i=0; i<array.Length; i++)
    {
        Console.Write ((i+1) + "   ");
    }

    Console.WriteLine ();
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
    Console.WriteLine ();
}

//Zad1 ();
//Zad2 ();
//Zad3 ();
Zad4 ();