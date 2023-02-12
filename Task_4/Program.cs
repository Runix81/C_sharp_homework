// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Программа, выводящая ряд четных чисел от 1 до заданного числа.");
Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (numberN < 0)
{
    numberN = numberN * -1;
}

if (numberN == 1)
{
    Console.Write("Число должно быть больше 1, введите другое число: ");
    numberN = Convert.ToInt32(Console.ReadLine());
}
while (count <= numberN)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}
