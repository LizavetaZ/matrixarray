int m = InputValue("Введите количество строк");
int n = InputValue("Введите количество столбцов");
int min = InputValue("Введите минимальное значение элемента массива");
int max = InputValue("Введите максимальное значение элемента массива");
int colomindex = 0;
if (IsInputValidate(m, n, min, max))
{
    int[,] array = CreateArray(m, n, min, max);
    PrintArray(array);
    int minRow = int.MaxValue;
    int indexMinRow = 1;
    while(colomindex < m)
    {
    int SUM = Sum(array, 0, colomindex);
    Console.WriteLine("Сумма = " + SUM);
    if (SUM < minRow)
    {
        minRow = SUM;
        indexMinRow = colomindex+1;
    }
    colomindex++;
    }
    Console.WriteLine("Номер строки с наименьшей суммой " + indexMinRow);
}
else Console.WriteLine("Ошибка вводимых данных");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}
bool IsInputValidate(int a, int b, int c, int d)
{
    if (a <= 0 || b <= 0 || c > d)
        return false;
    return true;
}
int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] a = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(min, max + 1);
        }
    }
    return a;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int Sum (int[,] Array, int Sum, int i)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Sum = Sum + Array[i, j];
    }
    return Sum;
}

