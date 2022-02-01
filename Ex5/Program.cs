Console.WriteLine("Введите три числа");
string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
string s3 = Console.ReadLine();
int num1 = int.Parse(s1);
int num2 = int.Parse(s2);
int num3 = int.Parse(s3);
int max = num1;
if (num2 > max)
{
    max = num2;
    if (num3 > max)
    {
        max = num3;
    }
}
else
{
    if (num3 > max)
    {
        max = num3;
    }
}
if (num1 == num2)
{
    if (num2 == num3)
    {
        Console.WriteLine("Числа равны");
    }
}
else
{
    Console.Write("max число = ");
    Console.WriteLine(max);
}