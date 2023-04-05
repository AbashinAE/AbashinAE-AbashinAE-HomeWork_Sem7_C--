// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageColumns = SrArif(array);
Console.WriteLine($"Среднее арифмитическое каждого столбца = {String.Join("; ", averageColumns)}");

//--------------- метод заполнения массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


//--------------- метод поиска значения -- 
double[] SrArif(int[,] arrayToSrAr)
{
  double[] res = new double[arrayToSrAr.GetLength(1)];
  for (int i = 0; i < arrayToSrAr.GetLength(0); i++)
  {
    for (int j = 0; j < arrayToSrAr.GetLength(1); j++)
    {
      res[j] += Convert.ToDouble(arrayToSrAr[i, j]);
    }
  }
  for (int i = 0; i < res.Length; i++)
  {
    res[i] = res[i] / arrayToSrAr.GetLength(0);

  }
  return res;
}


//--------------- метод поиска значения--- решение из семинара
// double[] GetResultArray(int[,] array)
// {
// double[] result = new double[array.GetLength(1)];
//   for (int i = 0; i < array.GetLength(1); i++)
//   {
//     double sum=0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//       sum+=array[j,i];
//     }
//     result[i]=Math.Round(sum/array.GetLength(0),2);
//   }
//   return result;
// }