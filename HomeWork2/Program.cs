// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число А");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В");
int num2 = Convert.ToInt32(Console.ReadLine());
void GetSumm()
{
    int i = 0;
    int sum = 1;
    while (i<num2)
    {
        sum = sum*num1;
        i++;
    }
    System.Console.WriteLine($"{num1},{num2} -> {sum}");
}
GetSumm();







// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число:");
int user_num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num1 = user_num;
while (num1>0)
{
    int num2 = num1%10;
    sum = sum + num2;
    num1 = num1/10;
}
System.Console.WriteLine($"{user_num} -> {sum}");







// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
int length = array.Length;
void GetArray()
{
    for (int i = 0; i <= length; i++)
        {
        array[i] = new Random().Next(0, 100);
        System.Console.Write(array[i]+" | ");
        }
}
GetArray();