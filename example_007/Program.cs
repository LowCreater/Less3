// 11. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе удаляет вторую
// цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// int num1 = num/100;
// int num2 = num%10;
// // Console.Write(num1);
// // Console.Write(num2);
// int result = num1*10+num2;
// Console.WriteLine(result);





// 12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// int num1 = new Random().Next(1,10);
// int num2 = new Random().Next(1,100);
// if (num2%num1==0)
// {
//     Console.WriteLine($"{num2}, {num1} -> кратно");
// }
// else
// {
//    Console.WriteLine($"{num2}, {num1} -> не кратно, остаток {num2%num1}");
// }




// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%7==0 && num%23==0)
// {
    
//     Console.WriteLine(num + " -> да");
// }
// else
// {
//     Console.WriteLine(num + " -> нет");
// }



// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (Math.Sqrt(num1)==num2 || Math.Sqrt(num2)==num1)
{
    Console.WriteLine($"{num2}, {num1} - > да");
}
else
{
    Console.WriteLine($"{num2}, {num1} - > нет");
}