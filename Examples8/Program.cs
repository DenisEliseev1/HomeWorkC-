// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write ("Введите максимальное число ряда :");
int number1 = Convert.ToInt32 (Console.ReadLine ());
int i=2;
while (i<number1)
    {
    if (Math.Abs(i)%2 == 0)
        {
            Console.Write (i + " ");
        }
    i++;    
    }