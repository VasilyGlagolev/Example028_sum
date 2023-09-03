// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерность первой матрицы:");
int n1 = int.Parse(Console.ReadLine());
int m1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите элементы первой матрицы:");

int[,] matrix1 = new int[n1, m1];

for (int i = 0; i < n1; i++)
{
    for (int j = 0; j < m1; j++)
    {
        Console.Write("Элемент [{0}, {1}]: ", i, j);
        matrix1[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Введите размерность второй матрицы:");
int n2 = int.Parse(Console.ReadLine());
int m2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите элементы второй матрицы:");

int[,] matrix2 = new int[n2, m2];

for (int i = 0; i < n2; i++)
{
    for (int j = 0; j < m2; j++)
    {
        Console.Write("Элемент [{0}, {1}]: ", i, j);
        matrix2[i, j] = int.Parse(Console.ReadLine());
    }
}

if (m1 != n2)
{
    Console.WriteLine("Умножение невозможно!");
}
else
{
    int[,] result = new int[n1, m2];

    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < m2; j++)
        {
            for (int k = 0; k < m1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    Console.WriteLine("Результат умножения матриц:");
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < m2; j++)
        {
            Console.Write("{0} ", result[i, j]);
        }
        Console.WriteLine();
    }
}
