// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetNumber(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size)
{
  return new int[size];
}

void FillArrayRandom(int[] collection)
{
  int size = collection.Length;
  for (int index = 0; index < size; index++)
  {
    collection[index] = new Random().Next(100, 1000);
  }
}

string Print(int[] array)
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
int[] value = CreateArray(size);
FillArrayRandom(value);
Console.WriteLine(Print(value));

int count = 0;

for (int index = 0; index < size; index++)
{
  if (value[index] % 2 == 0)
  {
    count += 1;
  }
}

Console.WriteLine($"Количество чётных чисел в массиве - {count}");