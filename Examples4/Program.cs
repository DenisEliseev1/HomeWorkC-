// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write ("Ввидите количество чисел для проверки :");
int length1 = Convert.ToInt32 (Console.ReadLine ());
int [] array = new int [length1];
int index=0;
int max=0;
Console.Write ("Сгенерированные числа для проверки :");
while (index<length1)
    {
        array [index] = new Random().Next(0, 100);
        Console.Write (array [index] + ",");
        if (array [index]>max)
            {
                max=array [index];
            }
        index++;
    }
Console.WriteLine ("\b. "); 
Console.WriteLine ("Максимальное число из списка =" + max);