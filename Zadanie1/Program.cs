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
            matr[i, j] = Math.Round((new Random().Next(-10, 10) * (new Random().NextDouble())), 2);;
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
            Console.Write(matr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}
double[,] matr = InputMatrix(m, n);
InputMatrix(m,n);
PrintMatrix(matr);
/*int sum = 0;
int sum2 = 0;
int razn = 0;
double[,] matr = InputMatrix(m, n);

int MinMax(int[,] matr) //Нахождение минимального и максимального значения в массиве и разницы между ними
{
    int max = -1000;
    
    int min = 101;
    int razn = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matr[i, j] > max)
            {
                max = matr[i, j];
            }
        }
        sum = sum + max;
        max = -1000;

    }


    for (int j = 0; j < n; j++)
    {

        for (int i = 0; i < m; i++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
            }
        }
        sum2 = sum2 + min;
        min = 101;
        razn = sum - sum2;
    }
    
    return razn; //разница по модулю между минимальным и максимальным значениями в массиве
}*/

//razn = MinMax(matr);

/*System.Console.WriteLine($"Сумма максимумов по строкам равна {sum} ");
System.Console.WriteLine($"Сумма минимумов по столбцам равна {sum2} ");
System.Console.WriteLine($"Разность между суммой максимумов по строкам и суммой минимумов по столбцам равна: {razn}");*/