// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0)
{
Console.Write("Вы ввели недопустимое значение");
return;
}
int[] GetArray(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(0, 100);
}
return array;
}
int[] result = GetArray(number);
void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
Console.Write($"{array[i]},");
}
Console.Write($"{array[array.Length - 1]}]");
}

PrintArray(result);