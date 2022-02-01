Console.WriteLine("Введите два числа");
string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
int num1 = int.Parse(s1);
int num2 = int.Parse(s2);
if (num1 == num2*num2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}
