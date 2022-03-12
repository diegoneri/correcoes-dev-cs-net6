string nome, sobrenome;
Console.Write("Digite seu nome.......: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome..: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");