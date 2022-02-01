Console.WriteLine("Введите номер дня недели");
string num = Console.ReadLine();
int den = int.Parse(num);
if (den == 1)
{
    Console.WriteLine("Понедельник");
}
if (den == 2)
{
    Console.WriteLine("Вторник");
}
if (den == 3)
{
    Console.WriteLine("Среда");
}
if (den == 4)
{
    Console.WriteLine("Четверг");
}
if (den == 5)
{
    Console.WriteLine("Пятница");
}
if (den == 6)
{
    Console.WriteLine("Суббота");
}
if (den == 7)
{
    Console.WriteLine("Воскресенье");
}
if (den < 1)
{
    Console.WriteLine("Дня недели с таким номером не существует");
}
if (den > 7)
{
    Console.WriteLine("Дня недели с таким номером не существует");
}