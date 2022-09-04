/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Write("Введите число для вычесления суммы цифры в числе: ");
int sum = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (sum > 0)
    {
        result += sum % 10;
        sum /= 10;
    }
Console.WriteLine(result);