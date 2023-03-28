// принимает на вход 3-х значное число,выдает вторую цифру этого числа
//варианты чисел 456,5782,8918,1
Console.Clear();
Console.WriteLine("введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 & num < 1000)
{
    int result = (num/10) % 10;
    Console.WriteLine($"третье число = {result}");
}
else 
{
    Console.WriteLine("твое число не трехзначное");
}