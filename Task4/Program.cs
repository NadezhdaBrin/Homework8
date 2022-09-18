// Написать программу вычисления функции Аккермана

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FunctionA(m, n));

int FunctionA(int m, int n)
{
    int result = 0;
    if(m == 0) return result = n + 1;
    if(m > 0 && n == 0) result = FunctionA(m - 1, 1);
    if (m > 0 && n > 0) result = FunctionA(m - 1, FunctionA(m, n - 1));
    return result;
}