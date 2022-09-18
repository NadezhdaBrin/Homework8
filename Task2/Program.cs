// Найти сумму элементов от M до N, N и M заданы

void Numbers (int M, int N, int SUM)
{
    if (M >  N) 
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N: {SUM}"); 
        return;
    }
    SUM = SUM + (M++);
    Numbers(M, N, SUM);
}

Numbers(1, 5, 0);