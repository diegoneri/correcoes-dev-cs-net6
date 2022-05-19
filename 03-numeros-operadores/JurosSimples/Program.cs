decimal capital, taxa, meses, juros, montante;

Console.WriteLine("Juros simples (j)\n");

Console.Write("Capital [c] (R$).......: ");
capital = Convert.ToDecimal(Console.ReadLine()!);

Console.Write("Taxa de juros [i] (%)..: ");
taxa = Convert.ToDecimal(Console.ReadLine()!);

Console.Write("Tempo [t] (meses)......: ");
meses = Convert.ToDecimal(Console.ReadLine()!);

juros = capital * (taxa / 100) * meses;
montante = capital + juros;

Console.WriteLine($"\nJuros.....: {juros:C2}");
Console.WriteLine($"Montante..: {montante:C2}");