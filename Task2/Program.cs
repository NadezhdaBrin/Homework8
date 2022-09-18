// Найти сумму элементов от M до N, N и M заданы

int SumElements(int m, int n)
{
    if (m == n) return m;
    return m + SumElements(m + 1, n);
}
Console.WriteLine(SumElements(1, 8));