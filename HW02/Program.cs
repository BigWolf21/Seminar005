// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    collection[index] = new Random().Next(-100, 100);
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

int summa = 0;
for (int index = 0; index < size; index++)
{
  if (index % 2 != 0)
  {
    summa += value[index];
  }
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве = {summa}");