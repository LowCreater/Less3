Console.Write("Введите день недели ");
int number = int.Parse(Console.ReadLine());
if (0<number || number<8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Сегодня выходной");
    }
    else
    {
        Console.WriteLine("Сегодня будни!");
    }
}
else 
{   
    Console.WriteLine("Такого дня недели нет!");
}