using static System.Console;

string GetAnswer(int a, int b)
{
    if(a%b==0)
    return $"Число {a} кратно {b}";
    return (a%b).ToString();
}

int a1=int.Parse(ReadLine());
int a2=int.Parse(ReadLine());

WriteLine(GetAnswer(a1,a2));
