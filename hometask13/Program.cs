//программа которая выводит 3 цифру заданного числа,если его нет то сообщает об этом
Console.Clear();
Console.WriteLine("введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 )
{
    while ( num >= 1000)
    {
    num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine("3 цифра -> " + result);
}
else 
{
    Console.WriteLine($"в числе {num} нету 3 цифры");
}

