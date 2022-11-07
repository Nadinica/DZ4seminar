// Задача 25: Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//A^B=A*A*A*A*A


Console.WriteLine("Введите А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B:");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
if (b != 0)
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
Console.WriteLine(result);