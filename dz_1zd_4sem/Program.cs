/* Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 
Не использовать Math.Pow()
*/


bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if(!isParsed || number < 1)
{
    Console.WriteLine("Некорректное число");
    return;
}
int stepen = GetStepenA(number);

Console.WriteLine(stepen);

int GetStepenA(int number)
{
    int a = number;
    int b = Convert.ToInt32(Console.ReadLine());
    int stepen = a;
   for (int i = 1; i < b; i++)
    {
        stepen = stepen * a;
    }
    return stepen;
}
