// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите строку: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [6,6];


void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i,j] = new Random().Next(1,10);  
        }
    }
}
FillArray(matrix);
PrintArray(matrix);

if (lines < 0 | lines > matrix.GetLength(0) - 1 | col < 0 | col > matrix.GetLength(1) - 1)
  {
    Console.WriteLine("Нет такого элемента ");
  }
else
{
    Console.WriteLine("элемент: " + matrix [lines,col]);
   }

// git remote add origin https://github.com/Alexperovo/DZ-task50.git
// git branch -M main
// git push -u origin main