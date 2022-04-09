// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Пример, 456 -> 3, 78 -> 2, 89126 -> 5

Console.Clear();

Random rnd = new Random();
int value = rnd.Next(0, 10000000);

//или вводим вручную число:
//int value = Promt("Введи целое число = ");

int len = value.ToString().Length;
Console.Write($"В числе {value} - {len} цифр");



//-----------------------------------------------------------------------------
int Promt(string message)
{
    Console.Write(message);
    string strMessage = Console.ReadLine();
    int answer = int.Parse(strMessage);
    return answer;
}