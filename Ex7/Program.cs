Console.WriteLine("Введите число");
string s1 = Console.ReadLine();
int num1 = int.Parse(s1);
if (num1%2 == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число является нечётным");
}