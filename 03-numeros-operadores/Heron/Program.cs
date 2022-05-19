double ladoUm, ladoDois, ladoTres;
double semiP;
double area;

Console.WriteLine("Digite os lados do triângulo desejado.\n");

Console.Write("Lado 1..: ");
ladoUm = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Lado 2..: ");
ladoDois = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Lado 3..: ");
ladoTres = Convert.ToDouble(Console.ReadLine()!);

semiP = (ladoUm + ladoDois + ladoTres) / 2;
area = Math.Sqrt(semiP * (semiP - ladoUm) * (semiP - ladoDois) * (semiP - ladoTres));

Console.WriteLine($"Semiperímetro..: {semiP}");
Console.WriteLine($"Área...........: {area}");