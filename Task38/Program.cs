// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
  double[] arr = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    double num = rnd.NextDouble() * (max - min) + min;
    arr[i] = Math.Round(num, 1);
  }
  return arr;
}

void PrintArrayDouble(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write(arr[i] + ",");
    else Console.Write(arr[i]);
  }
  Console.WriteLine("]");
}

double MaxArr(double[] arr)
{
  double maxArr = arr[0];
  for (int a = 0; a < arr.Length; a++)
  {
    if (arr[a] > maxArr)
      maxArr = arr[a];
  }
  return maxArr;
}

double MinArr(double[] arr)
{
  double minArr = arr[0];
  for (int a = 0; a < arr.Length; a++)
  {
    if (arr[a] < minArr)
      minArr = arr[a];
  }
  return minArr;
}

double[] array = CreateArrayRndDouble(5, 1, 79);
PrintArrayDouble(array);
double maxArr = MaxArr(array);
Console.WriteLine(maxArr);
double minArr = MinArr(array);
Console.WriteLine(minArr);
Console.WriteLine($"Result:  {Math.Round(maxArr - minArr, 1)}");

