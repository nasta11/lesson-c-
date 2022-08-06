Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max = 0;
 
max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;

{
Console.WriteLine("самое большое число = " + max);
}

Console.ReadKey();

