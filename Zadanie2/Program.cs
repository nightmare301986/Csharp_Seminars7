/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Ряд > 1
Колонка > 7
1, 7 -> такого числа в массиве нет*/

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
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SearchElemMatr(int[,] matr, int nomerStr, int nomerCol)//Поиск элемента (числа) в матрице по №строки и столбца
{
if (nomerStr > m || nomerCol > n || nomerStr <= 0 || nomerCol <= 0 ) 
{System.Console.WriteLine($"На такой позиции [{nomerStr} , {nomerCol}] чисел в данной матрице нет");}
else System.Console.WriteLine($"Искомое число:  {matr[nomerStr-1,nomerCol-1]} ");
}

int[,] matr = InputMatrix(m, n);
PrintMatrix(matr);

int nomerStr = Promt("№ строки  ");
int nomerCol = Promt("№ столбца   ");

SearchElemMatr(matr,nomerStr,nomerCol);
