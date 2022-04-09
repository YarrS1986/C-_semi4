// 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// пример, 7 -> 28, 4 -> 10, 8 -> 36

Console.Clear();







int Promt(string message)
{
    Console.Write(message);
    string strMessage = Console.ReadLine();
    int answer = int.Parse(strMessage);
    return answer;
}

void SumArray(int[] array) // этот метод задает массив
{
    int count = array.Length;
    int sum = 0;
    for (int ind = 1; ind <= count; ind++)
    {
        sum = sum + ind;
    }
    Console.Write($"{sum} ");
}

int value = Promt("Введи длину массива = ");
int[] arr = new int[value];
SumArray(arr);