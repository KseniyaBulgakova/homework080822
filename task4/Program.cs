Console.WriteLine("Введите первое число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int N3 = Convert.ToInt32(Console.ReadLine());
if (N1 > N2 & N1 > N3)
{
    Console.WriteLine("max: ");
    Console.Write(N1);
}
else if (N2 > N1 & N2 > N3)
{
   Console.WriteLine("max: ");
   Console.Write(N2);
}
else if (N3 >N1 & N3> N2)
{
    Console.WriteLine("max: ");
    Console.Write(N3);
}
