// Задача 29: Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран.
//N = 5, получаем массив[1, 2, 5, 7, 19]
//N = 3, получаем массив [6, 1, 33]



int[] CreateAndFill(int count)
{
    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        array[i] = Random.Shared.Next(1, 20);
    }
    return array;
}

void Print(int[] numbers)
{
    int size = numbers.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}
//int len = 10;

Console.WriteLine("Напишите число N ");
int len = Convert.ToInt32(Console.ReadLine());
int[] a = CreateAndFill(len);
Print(a);