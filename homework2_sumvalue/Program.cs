// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Пример, 452 -> 11, 82 -> 10, 9012 -> 12
Console.Clear();

int value = Promt("Введи число = ");
int sum = 0;

if (value >= 0)
{
    while (value != 0) // Раскладываем число по цифрам и суммируем
    {
        int num = value % 10;
        value = value / 10;
        sum = sum + num;

    }
    Console.WriteLine($"Число = {sum}");
}
else Console.WriteLine($"Введи положительное, целое число!");

Console.WriteLine();


//-----------------------------------------------------------------
int Promt(string message)
{
    Console.Write(message);
    string strMessage = Console.ReadLine();
    int answer = int.Parse(strMessage);
    return answer;
}