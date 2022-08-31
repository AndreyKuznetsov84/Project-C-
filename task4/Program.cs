// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using static System.Console;  //эта команда позволяет не писать Console каждый раз в новой строке
Clear();   //очищает терминал при каждом запуске программы

WriteLine("Введите три числа:");

int number_1 = Convert.ToInt32(Console.ReadLine());   //int.Parse преобразует строку (string) в int (если может).Convert.ToInt32 преобразует в int значение любого типа, из перечисленных здесь. boolean, double, float и т.д. А самое главное, может преобразовать экземпляр любого класса, реализующего IConvertible.
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2 > max) max = number_2;

if (number_3 > max) max = number_3;

Write("Максимальное число из трёх введённых - ");
WriteLine(max);