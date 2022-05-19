double milhas, kms;

Console.Write("Entre com a medida (em milhas): ");
milhas = Convert.ToDouble(Console.ReadLine()!);

kms = milhas * 1.609;

Console.WriteLine($"{kms:N3} Km");