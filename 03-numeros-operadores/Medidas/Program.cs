double m, cm, km;

Console.Write("Entre com a medida (em metros): ");
m = Convert.ToDouble(Console.ReadLine()!);

cm = m * 100;
km = m / 1000;

Console.WriteLine("\n--- Equivalência ---");
Console.WriteLine($"{cm} cm");
Console.WriteLine($"{m} m");
Console.WriteLine($"{km} Km");