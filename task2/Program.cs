Console.WriteLine("Введите первое число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N2 = Convert.ToInt32(Console.ReadLine());
if (N1 > N2)
{
    Console.Write("max: ");
    Console.Write(N1);
}
else if (N1 < N2)
{
    Console.Write("max: ");
    Console.Write(N2);
}