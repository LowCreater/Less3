// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// System.Console.WriteLine("Введите первую сторону треугольника:");
// int sideA = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите вторую сторону треугольника:");
// int sideB = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите третью сторону треугольника:");
// int sideC = int.Parse(Console.ReadLine());
// if (sideA<sideB+sideC && sideB<sideA+sideC && sideC<sideA+sideB)
// {
//     System.Console.WriteLine("Может!");
// }
// else
// {
//     System.Console.WriteLine("Не может!");
// }




// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// System.Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine());
// string result = "";
// while (num>0)
// {
//     result = num%2+result;
//     num = num/2;
// }

// System.Console.WriteLine(result);



// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int first = 0;
int second = 1;
System.Console.Write(first + " "+ second + " ");
for (int i = 2; i < num; i++)
{
    int nextNum = first + second;
    first = second;
    second = nextNum;
    System.Console.Write(nextNum+" ");
}