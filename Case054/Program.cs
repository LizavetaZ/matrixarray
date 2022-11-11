int row = InputValue("Введите количество строк");
int colom = InputValue("Введите количество столбцов");
int min = InputValue("Введите минимальное значение элемента массива");
int max = InputValue("Введите максимальное значение элемента массива");
if (IsInputValidate(row, colom, min, max))
{
    int[,] array = CreateArray(row, colom, min, max);
    PrintArray(array);
    Console.WriteLine();
    SortArray(array);
    PrintArray(array);
}
else Console.WriteLine("Ошибка вводимых данных");

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1]) 
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
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

bool IsInputValidate(int a, int b, int c, int d)
{
    if (a <= 0 || b <= 0 || c > d)
        return false;
    return true;
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
