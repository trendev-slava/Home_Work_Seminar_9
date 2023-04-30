int number = GetNumberInput("Введите число: ");
 Console.WriteLine();
PrintArrayNumbers(number);

int GetNumberInput(string message = "")
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

void PrintArrayNumbers(int number)
{
    if(number == 1)
    Console.WriteLine(number);
    else 
    {
        Console.Write($"{number} ");
        PrintArrayNumbers(number-1);
    }
    
}

