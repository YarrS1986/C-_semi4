// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Пример, 4 -> 24, 5 -> 120

Console.Clear();


int value = Promt("Введи длину массива = ");
int[] arr = new int[value];
SumArray(arr);


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
    int sum = 1;
    for (int ind = 1; ind <= count; ind++)
    {
        sum = sum * ind;
    }
    Console.Write($"{sum} ");
}
