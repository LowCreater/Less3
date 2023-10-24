// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void array(int arr)
{
    if (arr>0)
    {
        System.Console.Write(arr + " ");
        array(arr-1);
    }
}
System.Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0)
{
    System.Console.WriteLine("Некорректный ввод!");
}
else
{
    array(number);
}






// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int Summa = 0;
void Sum(int a, int b)
{
    for (int i = m; i <= n; i++)
    {
        Summa = Summa + i;
    }
    System.Console.WriteLine(Summa);
}
Sum(m, n);






// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//            n + 1                  при m = 0
// A(m,n) =   A(m-1,1)               при m > 0, n = 0
//            A(m-1, A(m, n - 1))    при m > 0, n > 0

System.Console.WriteLine("Введите целое неотрицательное число m");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите целое неотрицательное число n");
int n = int.Parse(Console.ReadLine());
int Ackerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (a > 0 && b == 0)
            {
                return Ackerman(a - 1, 1);
            }
            else if (a > 0 && b > 0)
                    {
                        return Ackerman(a - 1, Ackerman(a, b - 1));
                    }
                    else 
                    {
                        return -1;
                    }
}
int AckermanMethod = Ackerman(m, n);
if (AckermanMethod == -1)
{
    System.Console.WriteLine("Неверный ввод!");
}
else
System.Console.WriteLine(AckermanMethod);