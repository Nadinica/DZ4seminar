// Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
// 452->11
//82->10
// 9012->12

//1)Определить количество чифр в числе: 
//2)Число разложить на массив;
//3)суммировать числа массива;

Console.WriteLine("Напишите число ");
int value = Convert.ToInt32(Console.ReadLine());
int PoiskCount(int value)
{
    int result=0;
    while (value!=0)
    {
        result+=1;
        value=value/10;
    }
    return result;
}
int count1 = PoiskCount(value);
//Console.WriteLine(count1);
int [] Array(int value)  //2)Число разложить на массив;
{
    int count = PoiskCount(value)-1;
    int[]arrey = new int [count+1];
    while (value!=0)
    {
        arrey [count--]=value%10;
        value=value/10;
    }
    return arrey;
}
int Summa (int [] arrey) // 3)суммировать числа массива;
{
    int sum = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        sum=sum+arrey[i];
    }
    return sum;
}
Console.Write("Сумма цифр в числе ");
int [] arrey = Array (value);
int size = arrey.Length;
int index = 0;
while (index < size)
{
   Console.Write(arrey[index++]);
}

int S = Summa (arrey);
Console.Write(" равна ");
Console.WriteLine(S);