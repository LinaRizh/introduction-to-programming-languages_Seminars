Console.WriteLine("Введите число");
string s1 = Console.ReadLine();
int N = int.Parse(s1);
int i = 1;
while (i < N)
{
    if (i%2 == 0)
    {
        Console.Write(i );
    }
    else
    {
        Console.Write(" ");
    }
    i ++;
}
Console.WriteLine();


