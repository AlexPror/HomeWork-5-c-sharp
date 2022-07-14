/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


Console.Clear();
Console.Write("Введите число элементов массива: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrSize];
Random rnd = new Random();
int[] Array (int[] arrSize)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next (0,10);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int evenNumCountSum = 0;
int EvenNumCountSum (int arrSize)
{
    for(int i = 0; i < arrSize; i++)
    {
        if (array[i] % 2 != 0)
            evenNumCountSum +=array[i];       
    }
    return evenNumCountSum;
} 
Console.Write("Исходный массив: ");
Array(array);
Console.Write("\n");
EvenNumCountSum(arrSize);
Console.Write($"Сумма нечетных чисел в массиве: {evenNumCountSum} ");