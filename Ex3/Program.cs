Console.WriteLine("Введите два числа");
string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
int num1 = int.Parse(s1);
int num2 = int.Parse(s2);
if (num2 == num1)
{
    Console.WriteLine("Числа равны");
}
else
{ 
    if (num1 > num2)
    {
        Console.Write("max число = ");
        Console.WriteLine(num1);
        Console.Write("min число = ");
        Console.WriteLine(num2);
    }

    else
    {
        Console.Write("max число = ");
        Console.WriteLine(num2);
        Console.Write("min число = ");
        Console.WriteLine(num1);
    }
}