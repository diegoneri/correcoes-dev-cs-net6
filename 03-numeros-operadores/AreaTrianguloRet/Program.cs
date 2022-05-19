double b, h, area;

Console.Write("Base....: ");
b = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Altura..: ");
h = Convert.ToDouble(Console.ReadLine()!);

area = (b * h) / 2;

Console.WriteLine($"\nÁrea....: {area:N3}");