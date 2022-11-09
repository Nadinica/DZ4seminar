// Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
// 452->11
//82->10
// 9012->12

//1)Определить количество чифр в числе: 
//2)Число разложить на массив;
//3)суммировать числа массива;

Console.WriteLine("Напишите число ");
int Number = Convert.ToInt32(Console.ReadLine());
int PoiskCount(int Number)
{
    int result=0;
    while (Number!=0)
    {
        result+=1;
        Number=Number/10;
    }
    return result;
}
int count1 = PoiskCount(Number);
Console.WriteLine(count1);
int [] Array(int value)  //2)Число разложить на массив;
{
    int count = PoiskCount(Number)-1;
    int[]arrey = new int [count+1];
    while (value!=0)
    {
        arrey [count--]=Number%10;
        Number=Number/10;
    }
    return arrey;
}
//Array(arrey);
int Summa (int [] arrey) // 3)суммировать числа массива;
{
        int sum = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        sum=sum+i;
    }
    return sum;
}
int arr[]=Array(Number);
int sum =Summa(arr);
Console.WriteLine(sum);