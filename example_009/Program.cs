// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// int[] array = new int[12];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     System.Console.Write($"{array[i]}, ");
// }
// int sum1 = 0;
// int sum2 = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]<0)
//     {
//         sum1 = array[i] + sum1;
//     }
//     else
//     {
//         sum2 = array[i] + sum2;
//     }
// }
// System.Console.WriteLine($"\nСумма отрицательных чисел = {sum1} \nСумма положительных чисел = {sum2}");




// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] array = new int[12];
// int reverse = -1;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     System.Console.Write($"{array[i]}. ");
// }
// System.Console.WriteLine("\n");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * reverse;
//     System.Console.Write(array[i]+". ");
// }




// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int[] array = new int[12];
// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int bliz = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);
//     System.Console.Write($"{array[i]}. ");
//     if (number == array[i])
//     {
//         bliz = array[i];
//     }
// }
// if (bliz != 0)
// {
//     System.Console.WriteLine("\n-> да");
    
// }
// else
// {
//     System.Console.WriteLine("\n-> нет");
// }




// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[123];
// int bliz = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 1000);
//     System.Console.Write($"{array[i]}. ");
//     if (array[i] > 10 && array[i]< 100)
//     {
//         bliz++;
//     }
// }
// System.Console.WriteLine("\n-> "+bliz);




// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

// int[] array = new int[50];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 10);
//     System.Console.Write($"{array[i]}. ");
// }
// System.Console.WriteLine("\n");
// int kur = array.Length/2 + array.Length%2;
// int countArray = array.Length;
// int[] SumArray = new int[kur];
// for (int i = 0; i < kur; i++)
// {
//     if (i == kur-1)
//     {
//         System.Console.WriteLine(array[i]);
//         break;
//     }
    
//     SumArray[i] = array[i]*array[countArray-i-1];
//     System.Console.Write($"{SumArray[i]}. ");
// }




int chet = 0;
int CountEvenElements()
{
int[] array = new int[10];
      for (int i = 0; i<array.Length; i++)
      {
        array[i] = new Random().Next(100,1000);
        System.Console.Write(array[i]+" | ");
        if (array[i]%2==0)
        {
          chet++;          
        }
      }
return chet;
}
int chetnie = CountEvenElements();
System.Console.WriteLine();
System.Console.WriteLine(chetnie);


