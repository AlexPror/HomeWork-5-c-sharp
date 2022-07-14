/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
Console.Write("Введите число элементов массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrSize];
Random rnd = new Random();
int[] ThreeNumArray(int[] arrSize)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(99, 1000);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int oddNumCount = 0;
int OddNumCount(int arrSize)
{
    for (int i = 0; i < arrSize; i++)
    {
        if (array[i] % 2 == 0)
            oddNumCount++;
    }
    return oddNumCount;
}
Console.Write("Исходный массив: ");
ThreeNumArray(array);
Console.Write("\n");
OddNumCount(arrSize);
Console.Write($"Количество четных чисел в массиве: {oddNumCount} ");


