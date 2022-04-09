// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Пример,              3, 5 -> 243 (3⁵),                      2, 4 -> 16

Console.Clear();


int A = Promt("Введи число А = ");
int B = Promt("Введи число B = ");
int sum = 1;

for (int stepen = 1; stepen <= B; stepen++)
{
    sum *= A;
}

Console.WriteLine();
Console.WriteLine($"Число {A} в степени {B} = {sum}");
Console.WriteLine();


//-----------------------------------------------------------------
int Promt(string message)
{
    Console.Write(message);
    string strMessage = Console.ReadLine();
    int answer = int.Parse(strMessage);
    return answer;
}