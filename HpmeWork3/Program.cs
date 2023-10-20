// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

    
// Console.WriteLine("Введите числа, разделяя их запятыми или пробелами:");
// string input = Console.ReadLine();
// int count = 0;
// string[] numbers = input.Split(',', ' ');
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (int.TryParse(numbers[i], out int value) && value > 0)
//     {
//     count++;
//     }
// }
// Console.WriteLine("Количество чисел, больших 0: " + count);
        



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main(string[] args)
{
    Console.WriteLine("Введите значения для уравнения первой прямой (y = k1 * x + b1):");
    double k1 = GetDoubleFromUser("Введите k1: ");
    double b1 = GetDoubleFromUser("Введите b1: ");
    Console.WriteLine("Введите значения для уравнения второй прямой (y = k2 * x + b2):");
    double k2 = GetDoubleFromUser("Введите k2: ");
    double b2 = GetDoubleFromUser("Введите b2: ");

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine("Точка пересечения прямых: " + x + " " + y);
}
    
double GetDoubleFromUser(string prompt)
{
    double result;
    while (true)
    {
        Console.Write(prompt);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
    }
}
Main(args);
