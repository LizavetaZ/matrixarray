int row = InputValue("Введите количество строк");
int colom = InputValue("Введите количество столбцов");
int depth = InputValue("Введите третий размер");
int min = InputValue("Введите минимальное значение элемента массива");
int max = InputValue("Введите максимальное значение элемента массива");
if (IsInputValidate(row, colom, depth, min, max))
{
    int[,,] array = CreateArray(row, colom, depth, min, max);
    PrintArray(array);
}
else Console.WriteLine("Ошибка вводимых данных");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}

bool IsInputValidate(int a, int b, int c, int d, int e)
{
    if (a <= 0 || b <= 0 || c <= 0 || d > e)
        return false;
    return true;
}

int[,,] CreateArray(int m, int n, int z, int min, int max)
{
    int[,,] a = new int[m, n, z];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {
                a[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return a;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
           {
            Console.Write(array[i, j, k] + $"{(i,j,k)} ");
           }   
           Console.WriteLine();
        }
    }
}

