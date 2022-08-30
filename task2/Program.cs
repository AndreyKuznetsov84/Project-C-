// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console; //эта команда позволяет не писать Console каждый раз в новой строке
Clear();
WriteLine("Введите первое число: ");
int num_A = int.Parse(Console.ReadLine());

WriteLine("Введите второе число: ");
int num_B = int.Parse(Console.ReadLine());

if (num_A > num_B)
    {
        WriteLine("Первое число больше чем второе ");
    }
else
    {
        WriteLine("Второе число больше чем первое ");
    }
            