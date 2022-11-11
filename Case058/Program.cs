int row1 = InputValue("Введите количество строк для первой матрицы");
int colom1 = InputValue("Введите количество столбцов для первой матрицы");
int min1 = InputValue("Введите минимальное значение элемента массива для первой матрицы");
int max1 = InputValue("Введите максимальное значение элемента массива для первой матрицы");
int row2 = InputValue("Введите количество строк для второй матрицы");
int colom2 = InputValue("Введите количество столбцов для второй матрицы");
int min2 = InputValue("Введите минимальное значение элемента массива для второй матрицы");
int max2 = InputValue("Введите максимальное значение элемента массива для второй матрицы");
if (IsInputValidate(row1, colom1, min1, max1, row2, colom2, min2, max2))
{
    int[,] array1 = CreateArray(row1, colom1, min1, max1);
    int[,] array2 = CreateArray(row2, colom2, min2, max2);
    PrintArray(array1);
    Console.WriteLine();
    PrintArray(array2);
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    MiltipleArray(array1, array2, array3);
    Console.WriteLine();
    PrintArray(array3);
}
else Console.WriteLine("Ошибка вводимых данных");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}

bool IsInputValidate(int a, int b, int c, int d, int e, int f, int g, int k)
{
    if (a <= 0 || b <= 0 || b>a || c > d || e <= 0 || f <= 0 || e > f || g > k || a!=f)
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

int [,] MiltipleArray (int[,] Array1, int[,] Array2, int[,] Array3)
{
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array2.GetLength(1); j++)
        {
            for (int k = 0; k < Array2.GetLength(0); k++)
            {
                Array3[i,j] += Array1[i,k] * Array2[k,j];
            }
        }
    }
    return Array3;
}
