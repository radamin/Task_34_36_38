// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArray(int size)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(100, 1000);
  }
  return array;
}

void PrintArray (int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if(i < arr.Length - 1) Console.Write(arr[i] + ",");
    else Console.Write(arr[i]);
  }
  Console.WriteLine("]");
}

int QuantityPositive(int[] arr)
{
  int quantity = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}

int[] array = CreateArray(6);
PrintArray(array);
Console.WriteLine();

int quantity = QuantityPositive(array);
Console.WriteLine($"The number of even numbers in the array: {quantity}");
