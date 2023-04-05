// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine("");
PrintArray(array);

// ----------------Заполнение массива
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
  Random rnd = new Random();
  double[,] res = new double[m, n];

  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      res[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(maxValue - minValue), 1);
      //res[i, j] = new Random().NextDouble() * (maxValue - minValue); - из семинара
    }
  }
  return res;
}

// -----------------Вывод массива-----------------
void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
      //Console.Write($"{array[i, j]:F1} "); -из семинара (F1-кол-во знаков после ",")
    }
    Console.WriteLine();
  }
  }
