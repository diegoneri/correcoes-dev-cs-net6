Console.Clear();

Console.Write($"Números pares entre 0 e ? ");
int i = Convert.ToInt32(Console.ReadLine()!);
int j = 0;

while (j <= i)
{
    Console.Write($"{j} ");
    j+=2;
}   

Console.WriteLine();