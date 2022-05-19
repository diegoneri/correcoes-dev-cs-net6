double parcelaUm, parcelaDois, soma;

Console.WriteLine("Cálculo da soma entre dois números.");
Console.WriteLine("");

Console.Write("Digite o primeiro número: ");
parcelaUm = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Digite o segundo número: ");
parcelaDois = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("");

soma = parcelaUm + parcelaDois;
Console.WriteLine($"Soma: {soma}");