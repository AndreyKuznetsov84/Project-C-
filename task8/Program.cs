 // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using static System.Console;
Clear();

WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
WriteLine("Чётные числа от 1 до " + num);
int i = 1;
    if (i == 1)
        {
            i += 1;
        }
    while (i <= num)
        {
            Write(i + ", ");
            i += 2;
        }
