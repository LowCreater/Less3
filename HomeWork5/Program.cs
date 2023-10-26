// Random rnd = new Random();
// double n = rnd.NextDouble()*(-5 - 5)+5;
// System.Console.WriteLine(Math.Round(n,2));

System.Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение");
int minLimitRandom = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение");
int maxLimitRandom = int.Parse(Console.ReadLine() + 1);
Random rnd = new Random();
double rond = (maxLimitRandom - minLimitRandom)+minLimitRandom;
double [,] array = new double [m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.NextDouble()*rond;
        Console.Write(Math.Round(array[i,j],2) + "\t");
    }
    System.Console.WriteLine();
}

