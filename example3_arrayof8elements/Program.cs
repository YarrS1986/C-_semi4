// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Пример, [1,0,1,1,0,1,0,0]

Console.Clear();

int[] array = new int[8];

for (int ind = 0; ind < 8; ind++)
{
    Random rnd = new Random();
    int rndValue = rnd.Next(0, 2);
    array[ind] = rndValue;
    Console.Write($"{array[ind]} ");
}
