
Console.Clear();
Console.WriteLine("введите цифру обозначающую день недели(1,2,3,4,5,6,7.)");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday == 7 || weekday == 6) Console.WriteLine("этот день выходной");
else 
{
    Console.WriteLine("этот день не выходной");
}

