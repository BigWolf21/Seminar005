// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int GetNumber(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

double[] CreateArray(int size)
{
  return new double[size];
}

void FillArrayRandom(double[] collection)
{
  int size = collection.Length;
  for (int index = 0;  index < size; index++)
  {
    collection[index] = Math.Round(new Random().NextDouble() * new Random().Next(0, 100), 2);
  }

}

string Print(double[] array)
{
  string result = String.Empty;
  int len = array.Length;
  for (int index = 0; index < len; index++)
  {
    result = result + " " + array[index];
  }
  return result;
}

int size = GetNumber("Введите размер массива - ");
double[] value = CreateArray(size);
FillArrayRandom(value);
Console.WriteLine(Print(value));

double temp = 0;
for (int i = 0; i < size; i++)
{
  for (int j = 0; j < size - 1; j++)
  {
    if (value[j] > value[j + 1])
    {
      temp = value[j];
      value[j] = value[j + 1];
      value[j + 1] = temp;
    }
  }
}

Console.WriteLine(Print(value));
double diff = value[size - 1] - value[0];
Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {diff}");