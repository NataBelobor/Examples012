//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int []array = new int[5];
Random numbers = new Random();

int min = int.MaxValue;
int max = int.MinValue;
for (int i = 0; i < array.Length; i++)
{
  array[i] = numbers.Next(100);
  
  Console.WriteLine(array[i]+" ");
  if (array[i] < min)
     min = array[i];
  if (array[i] > max)
     max = array[i];
}

Console.WriteLine("Разница {0}", max - min);

