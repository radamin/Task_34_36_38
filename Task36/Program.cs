// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArray(int size)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(1, 10);
  }
  return array;
}

void PrintArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write(arr[i] + ",");
    else Console.Write(arr[i]);
  }
  Console.WriteLine("]");
}

int OddSumArr(int[] arr)
{
  int oddsum = 0;
  for (int i = 1; i < arr.Length; i++)
  {
    if (i % 2 != 0)
      oddsum += arr[i];
  }
  return oddsum;
}

int[] array = CreateArray(4);
PrintArray(array);
int oddsum = OddSumArr(array);
Console.WriteLine(oddsum);
