/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
int Promt(String message) //Приглашение ко вводу
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Promt("Введите число строк в матрице  ");
int n = Promt("Введите число столбцов в матрице  ");

double[,] InputMatrix(int m, int n ) //Заполнение матрицы с учетом размера (количества строк, столбцов)
{
    double[,] matr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = Math.Round((new Random().Next(-10, 10) * (new Random().NextDouble())), 2);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr)//Вывод матрицы на экран
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
double[,] matr = InputMatrix(m, n);
InputMatrix(m,n);
PrintMatrix(matr);