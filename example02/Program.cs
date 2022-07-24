//Задача 66: 
//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int SumPower(int M, int N )
{
    if (M == N) return M; // Базовый случай.
    return (M + SumPower(M +1, N)); // Рекурсивный случай.
    
}
Console.WriteLine(SumPower(M, N));