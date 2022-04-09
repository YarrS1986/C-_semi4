// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).
// Пример 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8                6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

Console.Clear();

int[] arr = new int[8];

FindArray(arr);
FillArray(arr);

//--------------------------------------------
void FindArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(1, 10);
    }
}

void FillArray(int[] collection)
{
    Console.Write($"[ ");
    for (int index = 0; index < collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.Write($"{collection[collection.Length - 1]} ]");
}