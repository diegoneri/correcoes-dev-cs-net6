double notaUm, notaDois, notaTres, media;

Console.WriteLine("Média Aritmética de 3 números\n");

Console.Write("Digite o primeiro número..: ");
notaUm = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o segundo número...: ");
notaDois = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o terceiro número..: ");
notaTres = Convert.ToDouble(Console.ReadLine()!);

media = (notaUm + notaDois + notaTres) / 3;

Console.WriteLine($"\nMédia: {media:N1}");
