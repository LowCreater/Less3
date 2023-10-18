// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int GetSumNum()
// {
//     int i = 1;
//     int sum = 0;
//     while (i<=number)
//     {
//         sum = sum+i;
//         i++;
//     }
//     return sum;
// }
// int sum = GetSumNum();
// System.Console.WriteLine(sum);




// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int GetSumNum()
// {
//     int i = 1;
//     int sum = 1;
//     while (i<=number)
//     {
//         sum = sum*i;
//         i++;
//     }
//     return sum;
// }
// int sum = GetSumNum();
// System.Console.WriteLine(sum);



// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
GetArray();
void GetArray()
{
    int length = array.Length;
    for(int i=0;i<=length;i++)
    {
        array[i] = new Random().Next(0,2);
        System.Console.Write(array[i]+" | ");
    }
}
