/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int Promt(String message) //Приглашение ко вводу
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Promt("Введите число строк в матрице  ");
int n = Promt("Введите число столбцов в матрице  ");

int[,] InputMatrix(int m, int n) //Заполнение матрицы с учетом размера (количества строк, столбцов)
{
    int[,] matr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().Next(0, 100);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)//Вывод матрицы на экран
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] matr = InputMatrix(m, n);

double Average(int[,] matr)
{
    double sum = 0;
    for (int j = 0; j < n; j++)
    {

        for (int i = 0; i < m; i++)
        {
            sum += matr[i, j];
        }
        System.Console.WriteLine($"Cреднее арифметическое по столбцу {j + 1} равно {sum / m} ");
        sum = 0;
    }
    return sum / m;
}

PrintMatrix(matr);
Average(matr);