// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = InputInt("Введите число M");
int n = InputInt("Введите число N");
SumFromMToN(m, n);

int InputInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}


void SumFromMToN(int m, int n)
{
    Console.Write($"Cумма натуральных элементов = {SumMN(m - 1, n)}");
}


int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
