// задача 64
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M - 1, N - 5, -> "1, 2, 3, 4, 5"
// M - 4, N - 8, -> "4, 5, 6, 7, 8"

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string printNumbers(int start, int end)
{
    //базавый случай.
    if(start == end) return start.ToString();
    //рекурсивный случай.
    return (start + " " + printNumbers(start +1, end));
}
Console.WriteLine(printNumbers(M,N));