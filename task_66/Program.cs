int n = GetNumberInput("N: ");
int m = GetNumberInput("M: ");

if (n < m) Console.WriteLine(SumOfElements(n, m));

else Console.WriteLine(SumOfElements(m, n));

int GetNumberInput(string message = "")
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumOfElements(int n, int m)
{
    if (n == m) return n;
    else return SumOfElements(n + 1, m) + n;
}

