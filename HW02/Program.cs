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
  int index = 0;
  while (index < size)
  {
    collection[index] = new Random().Next(-100, 100);
    index++;
  }

}

string Print(int[] array)
{
  string result = String.Empty;
  int len = array.Length;
  int index = 0;
  while (index < len)
  {
    result = result + " " + array[index];
    index++;
  }
  return result;
}

int size = GetNumber("Введите размер массива - ");
int[] value = CreateArray(size);
FillArrayRandom(value);
Console.WriteLine(Print(value));

int summa = 0;
int index = 0;
while (index < size)
{
  if (index % 2 != 0)
  {
    summa += value[index];
    index++;
  }
  else
  {
    index++;
  }
}

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массиве = " + summa);