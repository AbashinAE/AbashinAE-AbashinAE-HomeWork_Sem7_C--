// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет

Console.Write("Введите координату строки: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату столбца: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] arr = new int[rows, columns];

GetArray(arr);
PrintArray(arr);

//--------------- метод заполнения массива
void GetArray(int[,] massive)
{
  for (int i = 0; i < massive.GetLength(0); i++)
  {
    for (int j = 0; j < massive.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1, 10);

    }

  }
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}

//---------------  поиска значения

if (rows > arr.GetLength(0) || columns > arr.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"i =  {rows} , j = {columns} -> Такой элемент есть: {arr[rows-1,columns-1]}");
}